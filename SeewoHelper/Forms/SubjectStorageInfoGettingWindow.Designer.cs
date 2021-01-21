
namespace SeewoHelper.Forms
{
    partial class SubjectStorageInfoGettingWindow
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
            this.tableLayoutPanelButton = new System.Windows.Forms.TableLayoutPanel();
            this.buttonOK = new Sunny.UI.UIButton();
            this.buttonCancel = new Sunny.UI.UIButton();
            this.label1 = new Sunny.UI.UILabel();
            this.label2 = new Sunny.UI.UILabel();
            this.label3 = new Sunny.UI.UILabel();
            this.textBoxName = new Sunny.UI.UITextBox();
            this.textBoxPath = new Sunny.UI.UITextBox();
            this.textBoxKeywords = new Sunny.UI.UITextBox();
            this.buttonGettingPath = new Sunny.UI.UIButton();
            this.buttonEditKeyword = new Sunny.UI.UIButton();
            this.tableLayoutPanelButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelButton
            // 
            this.tableLayoutPanelButton.ColumnCount = 2;
            this.tableLayoutPanelButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelButton.Controls.Add(this.buttonOK, 0, 0);
            this.tableLayoutPanelButton.Controls.Add(this.buttonCancel, 1, 0);
            this.tableLayoutPanelButton.Location = new System.Drawing.Point(690, 143);
            this.tableLayoutPanelButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanelButton.Name = "tableLayoutPanelButton";
            this.tableLayoutPanelButton.RowCount = 1;
            this.tableLayoutPanelButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanelButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanelButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanelButton.Size = new System.Drawing.Size(195, 48);
            this.tableLayoutPanelButton.TabIndex = 2;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOK.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.buttonOK.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.buttonOK.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.buttonOK.Location = new System.Drawing.Point(3, 4);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonOK.MinimumSize = new System.Drawing.Size(1, 1);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.buttonOK.Size = new System.Drawing.Size(91, 40);
            this.buttonOK.Style = Sunny.UI.UIStyle.LightBlue;
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "确定";
            this.buttonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.buttonCancel.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.buttonCancel.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.buttonCancel.Location = new System.Drawing.Point(100, 4);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.buttonCancel.Size = new System.Drawing.Size(92, 40);
            this.buttonCancel.Style = Sunny.UI.UIStyle.LightBlue;
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "取消";
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 19);
            this.label1.Style = Sunny.UI.UIStyle.LightBlue;
            this.label1.TabIndex = 6;
            this.label1.Text = "科目名称：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 19);
            this.label2.Style = Sunny.UI.UIStyle.LightBlue;
            this.label2.TabIndex = 7;
            this.label2.Text = "指定路径：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.Style = Sunny.UI.UIStyle.LightBlue;
            this.label3.TabIndex = 8;
            this.label3.Text = "关键词：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxName
            // 
            this.textBoxName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxName.FillColor = System.Drawing.Color.White;
            this.textBoxName.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxName.Location = new System.Drawing.Point(83, 44);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxName.Maximum = 2147483647D;
            this.textBoxName.Minimum = -2147483648D;
            this.textBoxName.MinimumSize = new System.Drawing.Size(1, 1);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxName.Size = new System.Drawing.Size(815, 25);
            this.textBoxName.Style = Sunny.UI.UIStyle.LightBlue;
            this.textBoxName.TabIndex = 9;
            // 
            // textBoxPath
            // 
            this.textBoxPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPath.FillColor = System.Drawing.Color.White;
            this.textBoxPath.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPath.Location = new System.Drawing.Point(83, 76);
            this.textBoxPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPath.Maximum = 2147483647D;
            this.textBoxPath.Minimum = -2147483648D;
            this.textBoxPath.MinimumSize = new System.Drawing.Size(1, 1);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPath.Size = new System.Drawing.Size(768, 25);
            this.textBoxPath.Style = Sunny.UI.UIStyle.LightBlue;
            this.textBoxPath.TabIndex = 10;
            // 
            // textBoxKeywords
            // 
            this.textBoxKeywords.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxKeywords.FillColor = System.Drawing.Color.White;
            this.textBoxKeywords.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxKeywords.Location = new System.Drawing.Point(83, 110);
            this.textBoxKeywords.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxKeywords.Maximum = 2147483647D;
            this.textBoxKeywords.Minimum = -2147483648D;
            this.textBoxKeywords.MinimumSize = new System.Drawing.Size(1, 1);
            this.textBoxKeywords.Name = "textBoxKeywords";
            this.textBoxKeywords.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxKeywords.ReadOnly = true;
            this.textBoxKeywords.Size = new System.Drawing.Size(768, 25);
            this.textBoxKeywords.Style = Sunny.UI.UIStyle.LightBlue;
            this.textBoxKeywords.TabIndex = 11;
            // 
            // buttonGettingPath
            // 
            this.buttonGettingPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGettingPath.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.buttonGettingPath.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.buttonGettingPath.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGettingPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.buttonGettingPath.Location = new System.Drawing.Point(860, 76);
            this.buttonGettingPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonGettingPath.MinimumSize = new System.Drawing.Size(1, 1);
            this.buttonGettingPath.Name = "buttonGettingPath";
            this.buttonGettingPath.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.buttonGettingPath.Size = new System.Drawing.Size(38, 24);
            this.buttonGettingPath.Style = Sunny.UI.UIStyle.LightBlue;
            this.buttonGettingPath.TabIndex = 12;
            this.buttonGettingPath.Text = "...";
            this.buttonGettingPath.Click += new System.EventHandler(this.ButtonGettingPath_Click);
            // 
            // buttonEditKeyword
            // 
            this.buttonEditKeyword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEditKeyword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.buttonEditKeyword.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.buttonEditKeyword.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEditKeyword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.buttonEditKeyword.Location = new System.Drawing.Point(860, 110);
            this.buttonEditKeyword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonEditKeyword.MinimumSize = new System.Drawing.Size(1, 1);
            this.buttonEditKeyword.Name = "buttonEditKeyword";
            this.buttonEditKeyword.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.buttonEditKeyword.Size = new System.Drawing.Size(38, 24);
            this.buttonEditKeyword.Style = Sunny.UI.UIStyle.LightBlue;
            this.buttonEditKeyword.TabIndex = 13;
            this.buttonEditKeyword.Text = "编辑";
            this.buttonEditKeyword.Click += new System.EventHandler(this.ButtonEditKeyword_Click);
            // 
            // SubjectStorageInfoGettingWindow
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(901, 204);
            this.Controls.Add(this.buttonEditKeyword);
            this.Controls.Add(this.buttonGettingPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.textBoxKeywords);
            this.Controls.Add(this.tableLayoutPanelButton);
            this.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SubjectStorageInfoGettingWindow";
            this.Style = Sunny.UI.UIStyle.LightBlue;
            this.Text = "添加/编辑课件存储信息";
            this.Load += new System.EventHandler(this.SubjectStorageInfoGettingWindow_Load);
            this.tableLayoutPanelButton.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelButton;
        private Sunny.UI.UIButton buttonOK;
        private Sunny.UI.UIButton buttonCancel;
        private Sunny.UI.UILabel label1;
        private Sunny.UI.UILabel label2;
        private Sunny.UI.UILabel label3;
        private Sunny.UI.UITextBox textBoxName;
        private Sunny.UI.UITextBox textBoxPath;
        private Sunny.UI.UITextBox textBoxKeywords;
        private Sunny.UI.UIButton buttonGettingPath;
        private Sunny.UI.UIButton buttonEditKeyword;
    }
}