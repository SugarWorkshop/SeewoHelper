namespace SeewoHelper.Forms
{
    partial class AboutWindow
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanelPage1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.linkLabelGithub = new System.Windows.Forms.LinkLabel();
            this.labelVersion = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelPage2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelContributors = new System.Windows.Forms.Label();
            this.textBoxContributors = new System.Windows.Forms.TextBox();
            this.ButtonOK = new System.Windows.Forms.Button();
            this.tableLayoutPanelPage1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanelPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelPage1
            // 
            this.tableLayoutPanelPage1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelPage1.AutoSize = true;
            this.tableLayoutPanelPage1.ColumnCount = 1;
            this.tableLayoutPanelPage1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelPage1.Controls.Add(this.labelTitle, 0, 0);
            this.tableLayoutPanelPage1.Controls.Add(this.linkLabelGithub, 0, 2);
            this.tableLayoutPanelPage1.Controls.Add(this.labelVersion, 0, 1);
            this.tableLayoutPanelPage1.Location = new System.Drawing.Point(7, 8);
            this.tableLayoutPanelPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanelPage1.Name = "tableLayoutPanelPage1";
            this.tableLayoutPanelPage1.RowCount = 3;
            this.tableLayoutPanelPage1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelPage1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelPage1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelPage1.Size = new System.Drawing.Size(344, 205);
            this.tableLayoutPanelPage1.TabIndex = 1;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("微软雅黑", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(4, 0);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(336, 68);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "SeewoHelper";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabelGithub
            // 
            this.linkLabelGithub.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelGithub.AutoSize = true;
            this.linkLabelGithub.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkLabelGithub.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.linkLabelGithub.Location = new System.Drawing.Point(4, 136);
            this.linkLabelGithub.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelGithub.Name = "linkLabelGithub";
            this.linkLabelGithub.Size = new System.Drawing.Size(336, 69);
            this.linkLabelGithub.TabIndex = 1;
            this.linkLabelGithub.TabStop = true;
            this.linkLabelGithub.Text = "Github";
            this.linkLabelGithub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabelGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // labelVersion
            // 
            this.labelVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVersion.AutoSize = true;
            this.labelVersion.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelVersion.Location = new System.Drawing.Point(4, 68);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(336, 68);
            this.labelVersion.TabIndex = 1;
            this.labelVersion.Text = "应用版本：";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl.Location = new System.Drawing.Point(14, 17);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(368, 267);
            this.tabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanelPage1);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(360, 235);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "关于";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanelPage2);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(360, 235);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "贡献者";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelPage2
            // 
            this.tableLayoutPanelPage2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelPage2.ColumnCount = 1;
            this.tableLayoutPanelPage2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelPage2.Controls.Add(this.labelContributors, 0, 0);
            this.tableLayoutPanelPage2.Controls.Add(this.textBoxContributors, 0, 1);
            this.tableLayoutPanelPage2.Location = new System.Drawing.Point(7, 8);
            this.tableLayoutPanelPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanelPage2.Name = "tableLayoutPanelPage2";
            this.tableLayoutPanelPage2.RowCount = 2;
            this.tableLayoutPanelPage2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelPage2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanelPage2.Size = new System.Drawing.Size(344, 223);
            this.tableLayoutPanelPage2.TabIndex = 1;
            // 
            // labelContributors
            // 
            this.labelContributors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelContributors.AutoSize = true;
            this.labelContributors.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelContributors.Location = new System.Drawing.Point(4, 0);
            this.labelContributors.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelContributors.Name = "labelContributors";
            this.labelContributors.Size = new System.Drawing.Size(336, 55);
            this.labelContributors.TabIndex = 1;
            this.labelContributors.Text = "贡献者";
            this.labelContributors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxContributors
            // 
            this.textBoxContributors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxContributors.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxContributors.Location = new System.Drawing.Point(4, 59);
            this.textBoxContributors.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxContributors.Multiline = true;
            this.textBoxContributors.Name = "textBoxContributors";
            this.textBoxContributors.ReadOnly = true;
            this.textBoxContributors.Size = new System.Drawing.Size(336, 160);
            this.textBoxContributors.TabIndex = 1;
            this.textBoxContributors.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ButtonOK
            // 
            this.ButtonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ButtonOK.AutoSize = true;
            this.ButtonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonOK.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonOK.Location = new System.Drawing.Point(294, 292);
            this.ButtonOK.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(88, 44);
            this.ButtonOK.TabIndex = 1;
            this.ButtonOK.Text = "确定";
            this.ButtonOK.UseVisualStyleBackColor = true;
            // 
            // AboutWindow
            // 
            this.AcceptButton = this.ButtonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButtonOK;
            this.ClientSize = new System.Drawing.Size(396, 347);
            this.Controls.Add(this.ButtonOK);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "关于";
            this.Load += new System.EventHandler(this.AboutWindow_Load);
            this.tableLayoutPanelPage1.ResumeLayout(false);
            this.tableLayoutPanelPage1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanelPage2.ResumeLayout(false);
            this.tableLayoutPanelPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPage1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.LinkLabel linkLabelGithub;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPage2;
        private System.Windows.Forms.TextBox textBoxContributors;
        private System.Windows.Forms.Label labelContributors;
        private System.Windows.Forms.Button ButtonOK;
    }
}