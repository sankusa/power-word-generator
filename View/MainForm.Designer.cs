namespace PowerWordGenerator.View
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.generateTabPage = new System.Windows.Forms.TabPage();
            this.favoriteWordAddButton = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.resultCaptionLabel = new System.Windows.Forms.Label();
            this.wordGenerateButton = new System.Windows.Forms.Button();
            this.materialWordCountTextBox = new System.Windows.Forms.TextBox();
            this.materialWordCountCaptionLabel = new System.Windows.Forms.Label();
            this.materialWordTabPage = new System.Windows.Forms.TabPage();
            this.materialWordDeleteButton = new System.Windows.Forms.Button();
            this.materialWordAddTextBox = new System.Windows.Forms.TextBox();
            this.materialWordAddButton = new System.Windows.Forms.Button();
            this.materialWordListBox = new System.Windows.Forms.ListBox();
            this.favoriteWordTabPage = new System.Windows.Forms.TabPage();
            this.favoriteWordCopyButton = new System.Windows.Forms.Button();
            this.favoriteWordCopyTextBox = new System.Windows.Forms.TextBox();
            this.favoriteWordDeleteButton = new System.Windows.Forms.Button();
            this.favoriteWordListBox = new System.Windows.Forms.ListBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.categoryCaptionLabel = new System.Windows.Forms.Label();
            this.categoryAddButton = new System.Windows.Forms.Button();
            this.categoryDeleteButton = new System.Windows.Forms.Button();
            this.mainTabControl.SuspendLayout();
            this.generateTabPage.SuspendLayout();
            this.materialWordTabPage.SuspendLayout();
            this.favoriteWordTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTabControl.Controls.Add(this.generateTabPage);
            this.mainTabControl.Controls.Add(this.materialWordTabPage);
            this.mainTabControl.Controls.Add(this.favoriteWordTabPage);
            this.mainTabControl.Location = new System.Drawing.Point(13, 39);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(514, 304);
            this.mainTabControl.TabIndex = 0;
            // 
            // generateTabPage
            // 
            this.generateTabPage.Controls.Add(this.favoriteWordAddButton);
            this.generateTabPage.Controls.Add(this.resultTextBox);
            this.generateTabPage.Controls.Add(this.resultCaptionLabel);
            this.generateTabPage.Controls.Add(this.wordGenerateButton);
            this.generateTabPage.Controls.Add(this.materialWordCountTextBox);
            this.generateTabPage.Controls.Add(this.materialWordCountCaptionLabel);
            this.generateTabPage.Location = new System.Drawing.Point(4, 22);
            this.generateTabPage.Name = "generateTabPage";
            this.generateTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.generateTabPage.Size = new System.Drawing.Size(506, 278);
            this.generateTabPage.TabIndex = 0;
            this.generateTabPage.Text = "生成";
            this.generateTabPage.UseVisualStyleBackColor = true;
            // 
            // favoriteWordAddButton
            // 
            this.favoriteWordAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.favoriteWordAddButton.Location = new System.Drawing.Point(393, 32);
            this.favoriteWordAddButton.Name = "favoriteWordAddButton";
            this.favoriteWordAddButton.Size = new System.Drawing.Size(108, 23);
            this.favoriteWordAddButton.TabIndex = 5;
            this.favoriteWordAddButton.Text = "お気に入りに追加";
            this.favoriteWordAddButton.UseVisualStyleBackColor = true;
            this.favoriteWordAddButton.Click += new System.EventHandler(this.favoriteWordAddButton_Click);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultTextBox.Location = new System.Drawing.Point(77, 34);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(310, 19);
            this.resultTextBox.TabIndex = 4;
            // 
            // resultCaptionLabel
            // 
            this.resultCaptionLabel.AutoSize = true;
            this.resultCaptionLabel.Location = new System.Drawing.Point(6, 37);
            this.resultCaptionLabel.Name = "resultCaptionLabel";
            this.resultCaptionLabel.Size = new System.Drawing.Size(53, 12);
            this.resultCaptionLabel.TabIndex = 3;
            this.resultCaptionLabel.Text = "生成結果";
            // 
            // wordGenerateButton
            // 
            this.wordGenerateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.wordGenerateButton.Location = new System.Drawing.Point(393, 6);
            this.wordGenerateButton.Name = "wordGenerateButton";
            this.wordGenerateButton.Size = new System.Drawing.Size(107, 23);
            this.wordGenerateButton.TabIndex = 2;
            this.wordGenerateButton.Text = "生成";
            this.wordGenerateButton.UseVisualStyleBackColor = true;
            this.wordGenerateButton.Click += new System.EventHandler(this.wordGenerateButton_Click);
            // 
            // materialWordCountTextBox
            // 
            this.materialWordCountTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialWordCountTextBox.Location = new System.Drawing.Point(77, 8);
            this.materialWordCountTextBox.Name = "materialWordCountTextBox";
            this.materialWordCountTextBox.Size = new System.Drawing.Size(310, 19);
            this.materialWordCountTextBox.TabIndex = 1;
            this.materialWordCountTextBox.Text = "2";
            this.materialWordCountTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.materialWordCountTextBox_Validating);
            // 
            // materialWordCountCaptionLabel
            // 
            this.materialWordCountCaptionLabel.AutoSize = true;
            this.materialWordCountCaptionLabel.Location = new System.Drawing.Point(6, 11);
            this.materialWordCountCaptionLabel.Name = "materialWordCountCaptionLabel";
            this.materialWordCountCaptionLabel.Size = new System.Drawing.Size(65, 12);
            this.materialWordCountCaptionLabel.TabIndex = 0;
            this.materialWordCountCaptionLabel.Text = "使用単語数";
            // 
            // materialWordTabPage
            // 
            this.materialWordTabPage.Controls.Add(this.materialWordDeleteButton);
            this.materialWordTabPage.Controls.Add(this.materialWordAddTextBox);
            this.materialWordTabPage.Controls.Add(this.materialWordAddButton);
            this.materialWordTabPage.Controls.Add(this.materialWordListBox);
            this.materialWordTabPage.Location = new System.Drawing.Point(4, 22);
            this.materialWordTabPage.Name = "materialWordTabPage";
            this.materialWordTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.materialWordTabPage.Size = new System.Drawing.Size(506, 278);
            this.materialWordTabPage.TabIndex = 1;
            this.materialWordTabPage.Text = "単語";
            this.materialWordTabPage.UseVisualStyleBackColor = true;
            // 
            // materialWordDeleteButton
            // 
            this.materialWordDeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialWordDeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialWordDeleteButton.Enabled = false;
            this.materialWordDeleteButton.Location = new System.Drawing.Point(425, 245);
            this.materialWordDeleteButton.Name = "materialWordDeleteButton";
            this.materialWordDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.materialWordDeleteButton.TabIndex = 8;
            this.materialWordDeleteButton.Text = "削除";
            this.materialWordDeleteButton.UseVisualStyleBackColor = true;
            this.materialWordDeleteButton.Click += new System.EventHandler(this.materialWordDeleteButton_Click);
            // 
            // materialWordAddTextBox
            // 
            this.materialWordAddTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialWordAddTextBox.Location = new System.Drawing.Point(7, 6);
            this.materialWordAddTextBox.Name = "materialWordAddTextBox";
            this.materialWordAddTextBox.Size = new System.Drawing.Size(412, 19);
            this.materialWordAddTextBox.TabIndex = 7;
            // 
            // materialWordAddButton
            // 
            this.materialWordAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialWordAddButton.Location = new System.Drawing.Point(425, 4);
            this.materialWordAddButton.Name = "materialWordAddButton";
            this.materialWordAddButton.Size = new System.Drawing.Size(75, 23);
            this.materialWordAddButton.TabIndex = 6;
            this.materialWordAddButton.Text = "追加";
            this.materialWordAddButton.UseVisualStyleBackColor = true;
            this.materialWordAddButton.Click += new System.EventHandler(this.materialWordAddButton_Click);
            // 
            // materialWordListBox
            // 
            this.materialWordListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialWordListBox.FormattingEnabled = true;
            this.materialWordListBox.ItemHeight = 12;
            this.materialWordListBox.Location = new System.Drawing.Point(7, 31);
            this.materialWordListBox.Name = "materialWordListBox";
            this.materialWordListBox.Size = new System.Drawing.Size(493, 208);
            this.materialWordListBox.TabIndex = 0;
            this.materialWordListBox.SelectedIndexChanged += new System.EventHandler(this.materialWordListBox_SelectedIndexChanged);
            // 
            // favoriteWordTabPage
            // 
            this.favoriteWordTabPage.Controls.Add(this.favoriteWordCopyButton);
            this.favoriteWordTabPage.Controls.Add(this.favoriteWordCopyTextBox);
            this.favoriteWordTabPage.Controls.Add(this.favoriteWordDeleteButton);
            this.favoriteWordTabPage.Controls.Add(this.favoriteWordListBox);
            this.favoriteWordTabPage.Location = new System.Drawing.Point(4, 22);
            this.favoriteWordTabPage.Name = "favoriteWordTabPage";
            this.favoriteWordTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.favoriteWordTabPage.Size = new System.Drawing.Size(506, 278);
            this.favoriteWordTabPage.TabIndex = 2;
            this.favoriteWordTabPage.Text = "お気に入り";
            this.favoriteWordTabPage.UseVisualStyleBackColor = true;
            // 
            // favoriteWordCopyButton
            // 
            this.favoriteWordCopyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.favoriteWordCopyButton.Enabled = false;
            this.favoriteWordCopyButton.Location = new System.Drawing.Point(425, 4);
            this.favoriteWordCopyButton.Name = "favoriteWordCopyButton";
            this.favoriteWordCopyButton.Size = new System.Drawing.Size(75, 23);
            this.favoriteWordCopyButton.TabIndex = 5;
            this.favoriteWordCopyButton.Text = "コピー";
            this.favoriteWordCopyButton.UseVisualStyleBackColor = true;
            this.favoriteWordCopyButton.Click += new System.EventHandler(this.favoriteWordCopyButton_Click);
            // 
            // favoriteWordCopyTextBox
            // 
            this.favoriteWordCopyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.favoriteWordCopyTextBox.Location = new System.Drawing.Point(6, 6);
            this.favoriteWordCopyTextBox.Name = "favoriteWordCopyTextBox";
            this.favoriteWordCopyTextBox.ReadOnly = true;
            this.favoriteWordCopyTextBox.Size = new System.Drawing.Size(413, 19);
            this.favoriteWordCopyTextBox.TabIndex = 9;
            this.favoriteWordCopyTextBox.TextChanged += new System.EventHandler(this.favoriteWordCopyTextBox_TextChanged);
            // 
            // favoriteWordDeleteButton
            // 
            this.favoriteWordDeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.favoriteWordDeleteButton.Enabled = false;
            this.favoriteWordDeleteButton.Location = new System.Drawing.Point(425, 245);
            this.favoriteWordDeleteButton.Name = "favoriteWordDeleteButton";
            this.favoriteWordDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.favoriteWordDeleteButton.TabIndex = 5;
            this.favoriteWordDeleteButton.Text = "削除";
            this.favoriteWordDeleteButton.UseVisualStyleBackColor = true;
            this.favoriteWordDeleteButton.Click += new System.EventHandler(this.favoriteWordDeleteButton_Click);
            // 
            // favoriteWordListBox
            // 
            this.favoriteWordListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.favoriteWordListBox.FormattingEnabled = true;
            this.favoriteWordListBox.ItemHeight = 12;
            this.favoriteWordListBox.Location = new System.Drawing.Point(7, 31);
            this.favoriteWordListBox.Name = "favoriteWordListBox";
            this.favoriteWordListBox.Size = new System.Drawing.Size(493, 208);
            this.favoriteWordListBox.TabIndex = 0;
            this.favoriteWordListBox.SelectedIndexChanged += new System.EventHandler(this.favoriteWordListBox_SelectedIndexChanged);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(60, 12);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(301, 20);
            this.categoryComboBox.TabIndex = 1;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // categoryCaptionLabel
            // 
            this.categoryCaptionLabel.AutoSize = true;
            this.categoryCaptionLabel.Location = new System.Drawing.Point(11, 15);
            this.categoryCaptionLabel.Name = "categoryCaptionLabel";
            this.categoryCaptionLabel.Size = new System.Drawing.Size(39, 12);
            this.categoryCaptionLabel.TabIndex = 2;
            this.categoryCaptionLabel.Text = "カテゴリ";
            // 
            // categoryAddButton
            // 
            this.categoryAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.categoryAddButton.Location = new System.Drawing.Point(367, 10);
            this.categoryAddButton.Name = "categoryAddButton";
            this.categoryAddButton.Size = new System.Drawing.Size(75, 23);
            this.categoryAddButton.TabIndex = 3;
            this.categoryAddButton.Text = "追加";
            this.categoryAddButton.UseVisualStyleBackColor = true;
            this.categoryAddButton.Click += new System.EventHandler(this.categoryAddButton_Click);
            // 
            // categoryDeleteButton
            // 
            this.categoryDeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.categoryDeleteButton.Location = new System.Drawing.Point(448, 10);
            this.categoryDeleteButton.Name = "categoryDeleteButton";
            this.categoryDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.categoryDeleteButton.TabIndex = 4;
            this.categoryDeleteButton.Text = "削除";
            this.categoryDeleteButton.UseVisualStyleBackColor = true;
            this.categoryDeleteButton.Click += new System.EventHandler(this.categoryDeleteButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 355);
            this.Controls.Add(this.categoryDeleteButton);
            this.Controls.Add(this.categoryAddButton);
            this.Controls.Add(this.categoryCaptionLabel);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.mainTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Power Word Generator";
            this.mainTabControl.ResumeLayout(false);
            this.generateTabPage.ResumeLayout(false);
            this.generateTabPage.PerformLayout();
            this.materialWordTabPage.ResumeLayout(false);
            this.materialWordTabPage.PerformLayout();
            this.favoriteWordTabPage.ResumeLayout(false);
            this.favoriteWordTabPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage generateTabPage;
        private System.Windows.Forms.TabPage materialWordTabPage;
        private System.Windows.Forms.Button wordGenerateButton;
        private System.Windows.Forms.TextBox materialWordCountTextBox;
        private System.Windows.Forms.Label materialWordCountCaptionLabel;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label categoryCaptionLabel;
        private System.Windows.Forms.Button categoryAddButton;
        private System.Windows.Forms.Button categoryDeleteButton;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Label resultCaptionLabel;
        private System.Windows.Forms.Button favoriteWordAddButton;
        private System.Windows.Forms.ListBox materialWordListBox;
        private System.Windows.Forms.Button materialWordAddButton;
        private System.Windows.Forms.Button materialWordDeleteButton;
        private System.Windows.Forms.TextBox materialWordAddTextBox;
        private System.Windows.Forms.TabPage favoriteWordTabPage;
        private System.Windows.Forms.Button favoriteWordDeleteButton;
        private System.Windows.Forms.ListBox favoriteWordListBox;
        private System.Windows.Forms.TextBox favoriteWordCopyTextBox;
        private System.Windows.Forms.Button favoriteWordCopyButton;
    }
}

