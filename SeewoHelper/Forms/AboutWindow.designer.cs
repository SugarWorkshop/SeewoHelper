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
            this.ButtonOK = new Sunny.UI.UIButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelPage2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelContributors = new Sunny.UI.UILabel();
            this.textBoxContributors = new Sunny.UI.UITextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelPage1 = new System.Windows.Forms.TableLayoutPanel();
            this.linkLabelGithub = new Sunny.UI.UILinkLabel();
            this.labelVersion = new Sunny.UI.UILabel();
            this.labelTitle = new Sunny.UI.UILabel();
            this.tabControl = new Sunny.UI.UITabControl();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanelPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanelPage1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonOK
            // 
            this.ButtonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ButtonOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonOK.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonOK.Location = new System.Drawing.Point(271, 296);
            this.ButtonOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonOK.MinimumSize = new System.Drawing.Size(1, 1);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(87, 36);
            this.ButtonOK.TabIndex = 1;
            this.ButtonOK.Text = "确定";
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.tableLayoutPanelPage2);
            this.tabPage2.ForeColor = System.Drawing.Color.White;
            this.tabPage2.Location = new System.Drawing.Point(0, 40);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(367, 209);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "贡献者";
            // 
            // tableLayoutPanelPage2
            // 
            this.tableLayoutPanelPage2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelPage2.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanelPage2.ColumnCount = 1;
            this.tableLayoutPanelPage2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelPage2.Controls.Add(this.labelContributors, 0, 0);
            this.tableLayoutPanelPage2.Controls.Add(this.textBoxContributors, 0, 1);
            this.tableLayoutPanelPage2.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanelPage2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanelPage2.Name = "tableLayoutPanelPage2";
            this.tableLayoutPanelPage2.RowCount = 2;
            this.tableLayoutPanelPage2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelPage2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanelPage2.Size = new System.Drawing.Size(364, 205);
            this.tableLayoutPanelPage2.TabIndex = 1;
            // 
            // labelContributors
            // 
            this.labelContributors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelContributors.AutoSize = true;
            this.labelContributors.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelContributors.Location = new System.Drawing.Point(3, 0);
            this.labelContributors.Name = "labelContributors";
            this.labelContributors.Size = new System.Drawing.Size(358, 51);
            this.labelContributors.Style = Sunny.UI.UIStyle.Custom;
            this.labelContributors.TabIndex = 1;
            this.labelContributors.Text = "贡献者";
            this.labelContributors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxContributors
            // 
            this.textBoxContributors.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxContributors.FillColor = System.Drawing.Color.White;
            this.textBoxContributors.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxContributors.Location = new System.Drawing.Point(4, 56);
            this.textBoxContributors.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxContributors.Maximum = 2147483647D;
            this.textBoxContributors.Minimum = -2147483648D;
            this.textBoxContributors.MinimumSize = new System.Drawing.Size(1, 1);
            this.textBoxContributors.Multiline = true;
            this.textBoxContributors.Name = "textBoxContributors";
            this.textBoxContributors.Padding = new System.Windows.Forms.Padding(5);
            this.textBoxContributors.ReadOnly = true;
            this.textBoxContributors.Size = new System.Drawing.Size(356, 144);
            this.textBoxContributors.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.tableLayoutPanelPage1);
            this.tabPage1.ForeColor = System.Drawing.Color.White;
            this.tabPage1.Location = new System.Drawing.Point(0, 40);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(367, 209);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "关于";
            // 
            // tableLayoutPanelPage1
            // 
            this.tableLayoutPanelPage1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanelPage1.ColumnCount = 1;
            this.tableLayoutPanelPage1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelPage1.Controls.Add(this.linkLabelGithub, 0, 2);
            this.tableLayoutPanelPage1.Controls.Add(this.labelVersion, 0, 1);
            this.tableLayoutPanelPage1.Controls.Add(this.labelTitle, 0, 0);
            this.tableLayoutPanelPage1.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanelPage1.Location = new System.Drawing.Point(0, 4);
            this.tableLayoutPanelPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanelPage1.Name = "tableLayoutPanelPage1";
            this.tableLayoutPanelPage1.RowCount = 3;
            this.tableLayoutPanelPage1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelPage1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelPage1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelPage1.Size = new System.Drawing.Size(367, 205);
            this.tableLayoutPanelPage1.TabIndex = 1;
            // 
            // linkLabelGithub
            // 
            this.linkLabelGithub.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.linkLabelGithub.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelGithub.AutoSize = true;
            this.linkLabelGithub.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkLabelGithub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.linkLabelGithub.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.linkLabelGithub.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.linkLabelGithub.Location = new System.Drawing.Point(3, 136);
            this.linkLabelGithub.Name = "linkLabelGithub";
            this.linkLabelGithub.Size = new System.Drawing.Size(361, 69);
            this.linkLabelGithub.Style = Sunny.UI.UIStyle.Custom;
            this.linkLabelGithub.TabIndex = 1;
            this.linkLabelGithub.TabStop = true;
            this.linkLabelGithub.Text = "Github";
            this.linkLabelGithub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabelGithub.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.linkLabelGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // labelVersion
            // 
            this.labelVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVersion.AutoSize = true;
            this.labelVersion.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelVersion.Location = new System.Drawing.Point(3, 68);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(361, 68);
            this.labelVersion.Style = Sunny.UI.UIStyle.Custom;
            this.labelVersion.TabIndex = 1;
            this.labelVersion.Text = "应用版本：";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("微软雅黑", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(3, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(361, 68);
            this.labelTitle.Style = Sunny.UI.UIStyle.Custom;
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "SeewoHelper";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl.ItemSize = new System.Drawing.Size(150, 40);
            this.tabControl.Location = new System.Drawing.Point(3, 39);
            this.tabControl.MainPage = "";
            this.tabControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(367, 249);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tabControl.TabIndex = 1;
            this.tabControl.TabSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tabControl.TabUnSelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            // 
            // AboutWindow
            // 
            this.AcceptButton = this.ButtonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.CancelButton = this.ButtonOK;
            this.ClientSize = new System.Drawing.Size(373, 349);
            this.Controls.Add(this.ButtonOK);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutWindow";
            this.Text = "关于";
            this.Load += new System.EventHandler(this.AboutWindow_Load);
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanelPage2.ResumeLayout(false);
            this.tableLayoutPanelPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanelPage1.ResumeLayout(false);
            this.tableLayoutPanelPage1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIButton ButtonOK;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPage1;
        private Sunny.UI.UILinkLabel linkLabelGithub;
        private Sunny.UI.UILabel labelVersion;
        private Sunny.UI.UILabel labelTitle;
        private Sunny.UI.UITabControl tabControl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPage2;
        private Sunny.UI.UILabel labelContributors;
        private Sunny.UI.UITextBox textBoxContributors;
    }
}