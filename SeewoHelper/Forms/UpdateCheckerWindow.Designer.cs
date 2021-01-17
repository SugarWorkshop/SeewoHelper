namespace SeewoHelper.Forms
{
    partial class UpdateCheckerWindow
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
            this.labelTitle = new Sunny.UI.UILabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelPreRelease = new Sunny.UI.UILabel();
            this.linkLabelRelease = new Sunny.UI.UILinkLabel();
            this.linkLabelPrerelease = new Sunny.UI.UILinkLabel();
            this.labelRelease = new Sunny.UI.UILabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonOK
            // 
            this.ButtonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ButtonOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonOK.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonOK.Location = new System.Drawing.Point(284, 280);
            this.ButtonOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonOK.MinimumSize = new System.Drawing.Size(1, 1);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(97, 42);
            this.ButtonOK.Style = Sunny.UI.UIStyle.Custom;
            this.ButtonOK.TabIndex = 4;
            this.ButtonOK.Text = "确定";
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(3, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(363, 74);
            this.labelTitle.Style = Sunny.UI.UIStyle.Custom;
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "检查更新";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.labelTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 48);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(369, 213);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.labelPreRelease, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.linkLabelRelease, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.linkLabelPrerelease, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelRelease, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 78);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(363, 131);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // labelPreRelease
            // 
            this.labelPreRelease.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPreRelease.AutoSize = true;
            this.labelPreRelease.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPreRelease.ForeColor = System.Drawing.Color.White;
            this.labelPreRelease.Location = new System.Drawing.Point(3, 65);
            this.labelPreRelease.Name = "labelPreRelease";
            this.labelPreRelease.Size = new System.Drawing.Size(175, 66);
            this.labelPreRelease.Style = Sunny.UI.UIStyle.Custom;
            this.labelPreRelease.TabIndex = 1;
            this.labelPreRelease.Text = "最新开发版：";
            this.labelPreRelease.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // linkLabelRelease
            // 
            this.linkLabelRelease.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.linkLabelRelease.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelRelease.AutoSize = true;
            this.linkLabelRelease.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.linkLabelRelease.Enabled = false;
            this.linkLabelRelease.Font = new System.Drawing.Font("微软雅黑", 13.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkLabelRelease.ForeColor = System.Drawing.Color.White;
            this.linkLabelRelease.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabelRelease.LinkColor = System.Drawing.Color.Cyan;
            this.linkLabelRelease.Location = new System.Drawing.Point(184, 0);
            this.linkLabelRelease.Name = "linkLabelRelease";
            this.linkLabelRelease.Size = new System.Drawing.Size(176, 65);
            this.linkLabelRelease.Style = Sunny.UI.UIStyle.Custom;
            this.linkLabelRelease.TabIndex = 2;
            this.linkLabelRelease.TabStop = true;
            this.linkLabelRelease.Text = "检测中……";
            this.linkLabelRelease.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabelRelease.UseCompatibleTextRendering = true;
            this.linkLabelRelease.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.linkLabelRelease.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelRelease_LinkClicked);
            // 
            // linkLabelPrerelease
            // 
            this.linkLabelPrerelease.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.linkLabelPrerelease.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelPrerelease.AutoSize = true;
            this.linkLabelPrerelease.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.linkLabelPrerelease.Enabled = false;
            this.linkLabelPrerelease.Font = new System.Drawing.Font("微软雅黑", 13.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkLabelPrerelease.ForeColor = System.Drawing.Color.White;
            this.linkLabelPrerelease.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabelPrerelease.LinkColor = System.Drawing.Color.Cyan;
            this.linkLabelPrerelease.Location = new System.Drawing.Point(184, 65);
            this.linkLabelPrerelease.Name = "linkLabelPrerelease";
            this.linkLabelPrerelease.Size = new System.Drawing.Size(176, 66);
            this.linkLabelPrerelease.Style = Sunny.UI.UIStyle.Custom;
            this.linkLabelPrerelease.TabIndex = 3;
            this.linkLabelPrerelease.TabStop = true;
            this.linkLabelPrerelease.Text = "检测中……";
            this.linkLabelPrerelease.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabelPrerelease.UseCompatibleTextRendering = true;
            this.linkLabelPrerelease.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.linkLabelPrerelease.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelPreRelease_LinkClicked);
            // 
            // labelRelease
            // 
            this.labelRelease.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRelease.AutoSize = true;
            this.labelRelease.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRelease.ForeColor = System.Drawing.Color.White;
            this.labelRelease.Location = new System.Drawing.Point(3, 0);
            this.labelRelease.Name = "labelRelease";
            this.labelRelease.Size = new System.Drawing.Size(175, 65);
            this.labelRelease.Style = Sunny.UI.UIStyle.Custom;
            this.labelRelease.TabIndex = 0;
            this.labelRelease.Text = "最新正式版：";
            this.labelRelease.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UpdateCheckerWindow
            // 
            this.AcceptButton = this.ButtonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.CancelButton = this.ButtonOK;
            this.ClientSize = new System.Drawing.Size(396, 338);
            this.Controls.Add(this.ButtonOK);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateCheckerWindow";
            this.RectColor = System.Drawing.Color.Black;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "检查更新";
            this.Load += new System.EventHandler(this.UpgradeWindow_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIButton ButtonOK;
        private Sunny.UI.UILabel labelTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Sunny.UI.UILabel labelRelease;
        private Sunny.UI.UILabel labelPreRelease;
        private Sunny.UI.UILinkLabel linkLabelRelease;
        private Sunny.UI.UILinkLabel linkLabelPrerelease;
    }
}