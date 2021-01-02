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
            this.ButtonOK = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelRelease = new System.Windows.Forms.Label();
            this.labelPreRelease = new System.Windows.Forms.Label();
            this.linkLabelRelease = new System.Windows.Forms.LinkLabel();
            this.linkLabelPrerelease = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonOK
            // 
            this.ButtonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ButtonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonOK.Font = new System.Drawing.Font("微软雅黑", 9.5F, System.Drawing.FontStyle.Bold);
            this.ButtonOK.Location = new System.Drawing.Point(238, 247);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(89, 44);
            this.ButtonOK.TabIndex = 4;
            this.ButtonOK.Text = "确定";
            this.ButtonOK.UseVisualStyleBackColor = true;
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTitle.Location = new System.Drawing.Point(3, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(309, 119);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.40174F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.59826F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(315, 229);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.labelRelease, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelPreRelease, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.linkLabelRelease, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.linkLabelPrerelease, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 122);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(309, 104);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // labelRelease
            // 
            this.labelRelease.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRelease.AutoSize = true;
            this.labelRelease.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelRelease.Location = new System.Drawing.Point(3, 0);
            this.labelRelease.Name = "labelRelease";
            this.labelRelease.Size = new System.Drawing.Size(148, 52);
            this.labelRelease.TabIndex = 0;
            this.labelRelease.Text = "最新正式版：";
            this.labelRelease.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPreRelease
            // 
            this.labelPreRelease.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPreRelease.AutoSize = true;
            this.labelPreRelease.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.labelPreRelease.Location = new System.Drawing.Point(3, 52);
            this.labelPreRelease.Name = "labelPreRelease";
            this.labelPreRelease.Size = new System.Drawing.Size(148, 52);
            this.labelPreRelease.TabIndex = 1;
            this.labelPreRelease.Text = "最新开发版：";
            this.labelPreRelease.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // linkLabelRelease
            // 
            this.linkLabelRelease.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelRelease.AutoSize = true;
            this.linkLabelRelease.Enabled = false;
            this.linkLabelRelease.Font = new System.Drawing.Font("微软雅黑", 13.5F, System.Drawing.FontStyle.Bold);
            this.linkLabelRelease.Location = new System.Drawing.Point(157, 0);
            this.linkLabelRelease.Name = "linkLabelRelease";
            this.linkLabelRelease.Size = new System.Drawing.Size(149, 52);
            this.linkLabelRelease.TabIndex = 2;
            this.linkLabelRelease.TabStop = true;
            this.linkLabelRelease.Text = "检测中……";
            this.linkLabelRelease.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabelRelease.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelRelease_LinkClicked);
            // 
            // linkLabelPrerelease
            // 
            this.linkLabelPrerelease.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelPrerelease.AutoSize = true;
            this.linkLabelPrerelease.Enabled = false;
            this.linkLabelPrerelease.Font = new System.Drawing.Font("微软雅黑", 13.5F, System.Drawing.FontStyle.Bold);
            this.linkLabelPrerelease.Location = new System.Drawing.Point(157, 52);
            this.linkLabelPrerelease.Name = "linkLabelPrerelease";
            this.linkLabelPrerelease.Size = new System.Drawing.Size(149, 52);
            this.linkLabelPrerelease.TabIndex = 3;
            this.linkLabelPrerelease.TabStop = true;
            this.linkLabelPrerelease.Text = "检测中……";
            this.linkLabelPrerelease.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabelPrerelease.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelPreRelease_LinkClicked);
            // 
            // UpdateCheckerWindow
            // 
            this.AcceptButton = this.ButtonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButtonOK;
            this.ClientSize = new System.Drawing.Size(339, 303);
            this.Controls.Add(this.ButtonOK);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateCheckerWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "检查更新";
            this.Load += new System.EventHandler(this.UpgradeWindow_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ButtonOK;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelRelease;
        private System.Windows.Forms.Label labelPreRelease;
        private System.Windows.Forms.LinkLabel linkLabelRelease;
        private System.Windows.Forms.LinkLabel linkLabelPrerelease;
    }
}