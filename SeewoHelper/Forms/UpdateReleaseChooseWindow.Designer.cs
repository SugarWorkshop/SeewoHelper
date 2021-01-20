
namespace SeewoHelper.Forms
{
    partial class UpdateReleaseChooseWindow
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
            this.listBoxRelease = new Sunny.UI.UIListBox();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxFastGit = new Sunny.UI.UICheckBox();
            this.labelVersion = new Sunny.UI.UILabel();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxRelease
            // 
            this.listBoxRelease.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxRelease.AutoScroll = true;
            this.listBoxRelease.FillColor = System.Drawing.Color.White;
            this.listBoxRelease.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxRelease.ItemHeight = 35;
            this.listBoxRelease.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.listBoxRelease.Location = new System.Drawing.Point(4, 37);
            this.listBoxRelease.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxRelease.MinimumSize = new System.Drawing.Size(1, 1);
            this.listBoxRelease.Name = "listBoxRelease";
            this.listBoxRelease.Padding = new System.Windows.Forms.Padding(2);
            this.listBoxRelease.Size = new System.Drawing.Size(294, 325);
            this.listBoxRelease.Style = Sunny.UI.UIStyle.LightBlue;
            this.listBoxRelease.TabIndex = 0;
            this.listBoxRelease.Text = null;
            this.listBoxRelease.TextAlignment = System.Drawing.StringAlignment.Center;
            this.listBoxRelease.ItemDoubleClick += new System.EventHandler(this.ListBoxRelease_ItemDoubleClick);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.checkBoxFastGit, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.listBoxRelease, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.labelVersion, 0, 0);
            this.tableLayoutPanel.Location = new System.Drawing.Point(3, 38);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(302, 409);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // checkBoxFastGit
            // 
            this.checkBoxFastGit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.checkBoxFastGit.Checked = true;
            this.checkBoxFastGit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxFastGit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxFastGit.Location = new System.Drawing.Point(79, 370);
            this.checkBoxFastGit.MinimumSize = new System.Drawing.Size(1, 1);
            this.checkBoxFastGit.Name = "checkBoxFastGit";
            this.checkBoxFastGit.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.checkBoxFastGit.Size = new System.Drawing.Size(144, 36);
            this.checkBoxFastGit.Style = Sunny.UI.UIStyle.LightBlue;
            this.checkBoxFastGit.TabIndex = 1;
            this.checkBoxFastGit.Text = "使用FastGit加速";
            // 
            // labelVersion
            // 
            this.labelVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVersion.AutoSize = true;
            this.labelVersion.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelVersion.Location = new System.Drawing.Point(3, 0);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(296, 32);
            this.labelVersion.Style = Sunny.UI.UIStyle.LightBlue;
            this.labelVersion.TabIndex = 2;
            this.labelVersion.Text = "当前版本";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UpdateReleaseChooseWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(308, 450);
            this.Controls.Add(this.tableLayoutPanel);
            this.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateReleaseChooseWindow";
            this.Style = Sunny.UI.UIStyle.LightBlue;
            this.Text = "双击Release以下载";
            this.Load += new System.EventHandler(this.UpdateReleaseChooseWindow_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIListBox listBoxRelease;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private Sunny.UI.UICheckBox checkBoxFastGit;
        private Sunny.UI.UILabel labelVersion;
    }
}