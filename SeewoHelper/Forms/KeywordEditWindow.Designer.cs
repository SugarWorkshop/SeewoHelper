
namespace SeewoHelper.Forms
{
    partial class KeywordEditWindow
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
            this.listViewKeywords = new System.Windows.Forms.ListView();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.buttonDelete = new Sunny.UI.UIButton();
            this.buttonAdd = new Sunny.UI.UIButton();
            this.tableLayoutPanelButton = new System.Windows.Forms.TableLayoutPanel();
            this.buttonOK = new Sunny.UI.UIButton();
            this.buttonCancel = new Sunny.UI.UIButton();
            this.tableLayoutPanel.SuspendLayout();
            this.tableLayoutPanelButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewKeywords
            // 
            this.listViewKeywords.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listViewKeywords.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listViewKeywords.FullRowSelect = true;
            this.listViewKeywords.HideSelection = false;
            this.listViewKeywords.Location = new System.Drawing.Point(21, 49);
            this.listViewKeywords.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewKeywords.Name = "listViewKeywords";
            this.listViewKeywords.Size = new System.Drawing.Size(404, 585);
            this.listViewKeywords.TabIndex = 0;
            this.listViewKeywords.UseCompatibleStateImageBehavior = false;
            this.listViewKeywords.View = System.Windows.Forms.View.List;
            this.listViewKeywords.DoubleClick += new System.EventHandler(this.ListViewKeywords_DoubleClick);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.buttonDelete, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.buttonAdd, 0, 0);
            this.tableLayoutPanel.Location = new System.Drawing.Point(444, 49);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(108, 91);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDelete.Location = new System.Drawing.Point(3, 51);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDelete.MinimumSize = new System.Drawing.Size(1, 1);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(102, 33);
            this.buttonDelete.Style = Sunny.UI.UIStyle.Custom;
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "删除";
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAdd.Location = new System.Drawing.Point(3, 6);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAdd.MinimumSize = new System.Drawing.Size(1, 1);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(102, 32);
            this.buttonAdd.Style = Sunny.UI.UIStyle.Custom;
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "新建";
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // tableLayoutPanelButton
            // 
            this.tableLayoutPanelButton.ColumnCount = 2;
            this.tableLayoutPanelButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelButton.Controls.Add(this.buttonOK, 0, 0);
            this.tableLayoutPanelButton.Controls.Add(this.buttonCancel, 1, 0);
            this.tableLayoutPanelButton.Location = new System.Drawing.Point(359, 642);
            this.tableLayoutPanelButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanelButton.Name = "tableLayoutPanelButton";
            this.tableLayoutPanelButton.RowCount = 1;
            this.tableLayoutPanelButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanelButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanelButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanelButton.Size = new System.Drawing.Size(193, 46);
            this.tableLayoutPanelButton.TabIndex = 3;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOK.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonOK.Location = new System.Drawing.Point(3, 4);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonOK.MinimumSize = new System.Drawing.Size(1, 1);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(90, 38);
            this.buttonOK.Style = Sunny.UI.UIStyle.Custom;
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
            this.buttonCancel.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCancel.Location = new System.Drawing.Point(99, 4);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(91, 38);
            this.buttonCancel.Style = Sunny.UI.UIStyle.Custom;
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "取消";
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // KeywordEditWindow
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(561, 703);
            this.Controls.Add(this.tableLayoutPanelButton);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.listViewKeywords);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KeywordEditWindow";
            this.RectColor = System.Drawing.Color.Black;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "编辑关键词";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanelButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewKeywords;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelButton;
        private Sunny.UI.UIButton buttonOK;
        private Sunny.UI.UIButton buttonCancel;
        private Sunny.UI.UIButton buttonDelete;
        private Sunny.UI.UIButton buttonAdd;
    }
}