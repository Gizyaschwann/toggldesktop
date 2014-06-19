﻿namespace TogglDesktop
{
    partial class TimeEntryCellWithHeader
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelFormattedDate = new System.Windows.Forms.Label();
            this.labelDateDuration = new System.Windows.Forms.Label();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.entryNonFlickerPanel = new TogglDesktop.NonFlickerPanel();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelContinue = new System.Windows.Forms.Label();
            this.labelBillable = new System.Windows.Forms.Label();
            this.labelTag = new System.Windows.Forms.Label();
            this.labelDuration = new System.Windows.Forms.Label();
            this.labelProject = new System.Windows.Forms.Label();
            this.headerPanel.SuspendLayout();
            this.entryNonFlickerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelFormattedDate
            // 
            this.labelFormattedDate.AutoSize = true;
            this.labelFormattedDate.Font = new System.Drawing.Font("Lucida Sans Unicode", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(186)));
            this.labelFormattedDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.labelFormattedDate.Location = new System.Drawing.Point(15, 15);
            this.labelFormattedDate.Name = "labelFormattedDate";
            this.labelFormattedDate.Size = new System.Drawing.Size(67, 15);
            this.labelFormattedDate.TabIndex = 10;
            this.labelFormattedDate.Text = "Thu 22. Jan";
            // 
            // labelDateDuration
            // 
            this.labelDateDuration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDateDuration.Font = new System.Drawing.Font("Lucida Sans Unicode", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(186)));
            this.labelDateDuration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.labelDateDuration.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelDateDuration.Location = new System.Drawing.Point(228, 15);
            this.labelDateDuration.Name = "labelDateDuration";
            this.labelDateDuration.Size = new System.Drawing.Size(74, 15);
            this.labelDateDuration.TabIndex = 11;
            this.labelDateDuration.Text = "2 h 12 min";
            this.labelDateDuration.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // headerPanel
            // 
            this.headerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.headerPanel.Controls.Add(this.labelFormattedDate);
            this.headerPanel.Controls.Add(this.labelDateDuration);
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(314, 45);
            this.headerPanel.TabIndex = 12;
            // 
            // entryNonFlickerPanel
            // 
            this.entryNonFlickerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.entryNonFlickerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.entryNonFlickerPanel.Controls.Add(this.labelDescription);
            this.entryNonFlickerPanel.Controls.Add(this.labelContinue);
            this.entryNonFlickerPanel.Controls.Add(this.labelBillable);
            this.entryNonFlickerPanel.Controls.Add(this.labelTag);
            this.entryNonFlickerPanel.Controls.Add(this.labelDuration);
            this.entryNonFlickerPanel.Controls.Add(this.labelProject);
            this.entryNonFlickerPanel.Location = new System.Drawing.Point(0, 45);
            this.entryNonFlickerPanel.Name = "entryNonFlickerPanel";
            this.entryNonFlickerPanel.Size = new System.Drawing.Size(314, 55);
            this.entryNonFlickerPanel.TabIndex = 15;
            // 
            // labelDescription
            // 
            this.labelDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDescription.Font = new System.Drawing.Font("Lucida Sans Unicode", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(186)));
            this.labelDescription.Location = new System.Drawing.Point(15, 9);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(154, 17);
            this.labelDescription.TabIndex = 6;
            this.labelDescription.Text = "Blogpost about ne...";
            this.labelDescription.Click += new System.EventHandler(this.labelDescription_Click);
            // 
            // labelContinue
            // 
            this.labelContinue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelContinue.Image = global::TogglDesktop.Properties.Resources._continue;
            this.labelContinue.Location = new System.Drawing.Point(210, 15);
            this.labelContinue.Name = "labelContinue";
            this.labelContinue.Size = new System.Drawing.Size(24, 24);
            this.labelContinue.TabIndex = 14;
            this.labelContinue.Click += new System.EventHandler(this.labelContinue_Click);
            // 
            // labelBillable
            // 
            this.labelBillable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBillable.Image = global::TogglDesktop.Properties.Resources.icon_billable;
            this.labelBillable.Location = new System.Drawing.Point(190, 20);
            this.labelBillable.Name = "labelBillable";
            this.labelBillable.Size = new System.Drawing.Size(13, 13);
            this.labelBillable.TabIndex = 5;
            // 
            // labelTag
            // 
            this.labelTag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTag.Image = global::TogglDesktop.Properties.Resources.icon_tags;
            this.labelTag.Location = new System.Drawing.Point(175, 20);
            this.labelTag.Name = "labelTag";
            this.labelTag.Size = new System.Drawing.Size(13, 13);
            this.labelTag.TabIndex = 13;
            // 
            // labelDuration
            // 
            this.labelDuration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDuration.AutoSize = true;
            this.labelDuration.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(186)));
            this.labelDuration.Location = new System.Drawing.Point(239, 19);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(64, 16);
            this.labelDuration.TabIndex = 8;
            this.labelDuration.Text = "03:21:30";
            this.labelDuration.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelDuration.Click += new System.EventHandler(this.labelDuration_Click);
            // 
            // labelProject
            // 
            this.labelProject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProject.Font = new System.Drawing.Font("Lucida Sans Unicode", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(186)));
            this.labelProject.Location = new System.Drawing.Point(15, 29);
            this.labelProject.Name = "labelProject";
            this.labelProject.Size = new System.Drawing.Size(154, 17);
            this.labelProject.TabIndex = 9;
            this.labelProject.Text = "NEW - TOGGL";
            this.labelProject.Click += new System.EventHandler(this.labelProject_Click);
            // 
            // TimeEntryCellWithHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Controls.Add(this.entryNonFlickerPanel);
            this.Controls.Add(this.headerPanel);
            this.Name = "TimeEntryCellWithHeader";
            this.Size = new System.Drawing.Size(314, 101);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TimeEntryCellWithHeader_MouseClick);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.entryNonFlickerPanel.ResumeLayout(false);
            this.entryNonFlickerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelProject;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelBillable;
        private System.Windows.Forms.Label labelFormattedDate;
        private System.Windows.Forms.Label labelDateDuration;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label labelTag;
        private System.Windows.Forms.Label labelContinue;
        private NonFlickerPanel entryNonFlickerPanel;
    }
}
