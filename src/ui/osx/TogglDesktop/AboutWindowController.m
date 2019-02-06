//
//  AboutWindowController.m
//  Toggl Desktop on the Mac
//
//  Created by Tanel Lebedev on 29/10/2013.
//  Copyright (c) 2013 TogglDesktop developers. All rights reserved.
//

#import "AboutWindowController.h"
#import "UIEvents.h"
#import "toggl_api.h"
#import "DisplayCommand.h"
#import "Utils.h"
#import "UnsupportedNotice.h"
#import "NSTextFieldClickablePointer.h"
#import "ConvertHexColor.h"
#import "TogglDesktop-Swift.h"

static NSString *const kTogglDesktopGithubURL = @"https://github.com/toggl/toggldesktop";

typedef enum : NSUInteger
{
	DownloadStateRestart,
	DownloadStateDownloading,
	DownloadStateNone
} DownloadState;

@interface AboutWindowController () <NSTextFieldDelegate>
@property (weak) IBOutlet NSTextField *appnameTextField;
@property (weak) IBOutlet NSTextField *versionTextField;
@property (weak) IBOutlet NSTextField *updateStatusTextField;
@property (weak) IBOutlet NSComboBox *updateChannelComboBox;
@property (weak) IBOutlet NSTextField *updateChannelLabel;
@property (weak) IBOutlet FlatButton *restartButton;
@property (weak) IBOutlet NSTextFieldClickablePointer *findUsInGithub;
@property (weak) IBOutlet NSBox *boxView;
@property (assign, nonatomic) DownloadState downloadState;
@end

@implementation AboutWindowController

extern void *ctx;

- (void)windowDidLoad
{
	[super windowDidLoad];

	[self.window setBackgroundColor:[NSColor colorWithPatternImage:[NSImage imageNamed:@"background-pattern"]]];

	NSDictionary *infoDict = [[NSBundle mainBundle] infoDictionary];
	NSString *version = [infoDict objectForKey:@"CFBundleShortVersionString"];
	[self.versionTextField setStringValue:[NSString stringWithFormat:@"Version %@", version]];

	self.windowHasLoad = YES;
	self.restart = NO;

	char *str = toggl_get_update_channel(ctx);
	self.updateChannelComboBox.stringValue = [NSString stringWithUTF8String:str];
	free(str);

	if ([self updateCheckEnabled])
	{
		self.updateChannelComboBox.hidden = NO;
		self.updateChannelLabel.hidden = NO;

		if (![[SUUpdater sharedUpdater] updateInProgress])
		{
			[self checkForUpdates];
		}

		[self displayUpdateStatus];
	}

	[self initCommon];
}

- (void)initCommon {
	self.findUsInGithub.delegate = self;

	self.findUsInGithub.titleUnderline = YES;

	self.boxView.wantsLayer = YES;
	self.boxView.layer.masksToBounds = NO;
	self.boxView.shadow = [[NSShadow alloc] init];
	self.boxView.layer.shadowColor = [NSColor colorWithWhite:0 alpha:0.1].CGColor;
	self.boxView.layer.shadowOpacity = 1.0;
	self.boxView.layer.shadowOffset = CGSizeMake(0, -2);
	self.boxView.layer.shadowRadius = 6;

	self.downloadState = DownloadStateNone;
}

- (BOOL)updateCheckEnabled
{
	NSDictionary *infoDict = [[NSBundle mainBundle] infoDictionary];

	return [infoDict[@"KopsikCheckForUpdates"] boolValue];
}

- (void)checkForUpdates
{
	if (![[UnsupportedNotice sharedInstance] validateOSVersion])
	{
		return;
	}
	if (![self updateCheckEnabled])
	{
		return;
	}
	[[SUUpdater sharedUpdater] resetUpdateCycle];
	[[SUUpdater sharedUpdater] checkForUpdatesInBackground];
}

- (void)updater:(SUUpdater *)updater willInstallUpdateOnQuit:(SUAppcastItem *)item immediateInstallationInvocation:(NSInvocation *)invocation
{
	NSLog(@"Download finished: %@", item.displayVersionString);

	self.updateStatus =
		[NSString stringWithFormat:@"Restart app to upgrade to %@",
		 item.displayVersionString];

	[self displayUpdateStatus];
	self.downloadState = DownloadStateRestart;
}

- (void)updater:(SUUpdater *)updater didFindValidUpdate:(SUAppcastItem *)update
{
	NSLog(@"update found: %@", update.displayVersionString);

	self.updateStatus =
		[NSString stringWithFormat:@"Update found: %@",
		 update.displayVersionString];

	self.downloadState = DownloadStateNone;
	[self displayUpdateStatus];
	[Utils runClearCommand];
}

- (void)displayUpdateStatus
{
	NSLog(@"automaticallyDownloadsUpdates=%d", [[SUUpdater sharedUpdater] automaticallyDownloadsUpdates]);

	if (self.updateStatus)
	{
		self.updateStatusTextField.stringValue = self.updateStatus;
		[self.updateStatusTextField setHidden:NO];
	}
	else
	{
		[self.updateStatusTextField setHidden:YES];
	}
}

- (BOOL)isVisible
{
	if (!self.windowHasLoad)
	{
		return NO;
	}
	return self.window.isVisible;
}

- (IBAction)updateChannelSelected:(id)sender
{
	NSString *updateChannel = self.updateChannelComboBox.stringValue;

	toggl_set_update_channel(ctx, [updateChannel UTF8String]);

	[Utils setUpdaterChannel:updateChannel];

	[self checkForUpdates];
}

- (IBAction)clickRestartButton:(id)sender;
{
	self.restart = YES;
	[[NSApplication sharedApplication] terminate:nil];
}

- (void)updaterDidNotFindUpdate:(SUUpdater *)update
{
	NSLog(@"No update found");
}

- (void)updater:(SUUpdater *)updater willInstallUpdate:(SUAppcastItem *)update
{
	NSLog(@"Will install update %@", update.displayVersionString);
}

- (void)updater:(SUUpdater *)updater didAbortWithError:(NSError *)error
{
	NSLog(@"Update check failed with error %@", error);
}

- (void)updater:(SUUpdater *)updater willDownloadUpdate:(SUAppcastItem *)item withRequest:(NSMutableURLRequest *)request
{
	self.downloadState = DownloadStateDownloading;
}

- (void)textFieldClicked:(id)sender
{
	if (sender == self.findUsInGithub)
	{
		[[NSWorkspace sharedWorkspace] openURL:[NSURL URLWithString:kTogglDesktopGithubURL]];
		return;
	}
}

- (void)setDownloadState:(DownloadState)downloadState
{
	_downloadState = downloadState;

	// Render button
	switch (downloadState)
	{
		case DownloadStateNone :
			self.restartButton.hidden = YES;
			break;
		case DownloadStateDownloading :
			self.restartButton.hidden = NO;
			self.restartButton.stringValue = @"Downloading...";
			self.restartButton.enabled = NO;
			self.restartButton.bgColor = NSColor.controlColor;
			self.restartButton.textColor = NSColor.textColor;
			break;
		case DownloadStateRestart :
			self.restartButton.hidden = NO;
			self.restartButton.stringValue = @"Restart";
			self.restartButton.enabled = YES;
			if (@available(macOS 10.13, *))
			{
				self.restartButton.bgColor = [NSColor colorNamed:@"green-color"];
			}
			else
			{
				self.restartButton.bgColor = [ConvertHexColor hexCodeToNSColor:@"#28cd41"];
			}
			self.restartButton.textColor = [NSColor whiteColor];
			break;
	}
}

@end
