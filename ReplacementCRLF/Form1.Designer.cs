namespace ReplacementCRLF
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
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
            this.InputFile = new System.Windows.Forms.TextBox();
            this.InputFileSelect = new System.Windows.Forms.Button();
            this.OutputDir = new System.Windows.Forms.TextBox();
            this.OutputDirSelect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ConvertStartBtn = new System.Windows.Forms.Button();
            this.LF2CRLF = new System.Windows.Forms.RadioButton();
            this.CRLF2LF = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // InputFile
            // 
            this.InputFile.AllowDrop = true;
            this.InputFile.Location = new System.Drawing.Point(12, 24);
            this.InputFile.Name = "InputFile";
            this.InputFile.Size = new System.Drawing.Size(452, 19);
            this.InputFile.TabIndex = 0;
            this.InputFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.InputFile_DragDrop);
            this.InputFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.InputFile_DragEnter);
            // 
            // InputFileSelect
            // 
            this.InputFileSelect.Location = new System.Drawing.Point(488, 24);
            this.InputFileSelect.Name = "InputFileSelect";
            this.InputFileSelect.Size = new System.Drawing.Size(80, 24);
            this.InputFileSelect.TabIndex = 1;
            this.InputFileSelect.Text = "Select";
            this.InputFileSelect.UseVisualStyleBackColor = true;
            this.InputFileSelect.Click += new System.EventHandler(this.InputFileSelect_Click);
            // 
            // OutputDir
            // 
            this.OutputDir.AllowDrop = true;
            this.OutputDir.Location = new System.Drawing.Point(12, 72);
            this.OutputDir.Name = "OutputDir";
            this.OutputDir.Size = new System.Drawing.Size(452, 19);
            this.OutputDir.TabIndex = 2;
            // 
            // OutputDirSelect
            // 
            this.OutputDirSelect.Location = new System.Drawing.Point(488, 72);
            this.OutputDirSelect.Name = "OutputDirSelect";
            this.OutputDirSelect.Size = new System.Drawing.Size(80, 24);
            this.OutputDirSelect.TabIndex = 3;
            this.OutputDirSelect.Text = "Select";
            this.OutputDirSelect.UseVisualStyleBackColor = true;
            this.OutputDirSelect.Click += new System.EventHandler(this.OutputDirSelect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "InputFilePath :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "OutputDirPath :";
            // 
            // ConvertStartBtn
            // 
            this.ConvertStartBtn.Location = new System.Drawing.Point(488, 112);
            this.ConvertStartBtn.Name = "ConvertStartBtn";
            this.ConvertStartBtn.Size = new System.Drawing.Size(80, 24);
            this.ConvertStartBtn.TabIndex = 8;
            this.ConvertStartBtn.Text = "Start";
            this.ConvertStartBtn.UseVisualStyleBackColor = true;
            this.ConvertStartBtn.Click += new System.EventHandler(this.ConvertStartBtn_Click);
            // 
            // LF2CRLF
            // 
            this.LF2CRLF.AutoSize = true;
            this.LF2CRLF.Location = new System.Drawing.Point(24, 112);
            this.LF2CRLF.Name = "LF2CRLF";
            this.LF2CRLF.Size = new System.Drawing.Size(85, 16);
            this.LF2CRLF.TabIndex = 9;
            this.LF2CRLF.TabStop = true;
            this.LF2CRLF.Text = "LF → CRLF";
            this.LF2CRLF.UseVisualStyleBackColor = true;
            // 
            // CRLF2LF
            // 
            this.CRLF2LF.AutoSize = true;
            this.CRLF2LF.Location = new System.Drawing.Point(120, 112);
            this.CRLF2LF.Name = "CRLF2LF";
            this.CRLF2LF.Size = new System.Drawing.Size(85, 16);
            this.CRLF2LF.TabIndex = 10;
            this.CRLF2LF.TabStop = true;
            this.CRLF2LF.Text = "CRLF → LF";
            this.CRLF2LF.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(597, 148);
            this.Controls.Add(this.CRLF2LF);
            this.Controls.Add(this.LF2CRLF);
            this.Controls.Add(this.ConvertStartBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OutputDirSelect);
            this.Controls.Add(this.OutputDir);
            this.Controls.Add(this.InputFileSelect);
            this.Controls.Add(this.InputFile);
            this.Name = "Form1";
            this.Text = "改行置き換え";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputFile;
        private System.Windows.Forms.Button InputFileSelect;
        private System.Windows.Forms.TextBox OutputDir;
        private System.Windows.Forms.Button OutputDirSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ConvertStartBtn;
        private System.Windows.Forms.RadioButton LF2CRLF;
        private System.Windows.Forms.RadioButton CRLF2LF;
    }
}

