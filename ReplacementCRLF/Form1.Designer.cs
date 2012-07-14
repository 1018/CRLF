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
            this.LF2CRLF = new System.Windows.Forms.CheckBox();
            this.CRLF2LF = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InputFile
            // 
            this.InputFile.AllowDrop = true;
            this.InputFile.Location = new System.Drawing.Point(12, 40);
            this.InputFile.Name = "InputFile";
            this.InputFile.Size = new System.Drawing.Size(452, 19);
            this.InputFile.TabIndex = 0;
            this.InputFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.InputFile_DragDrop);
            this.InputFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.InputFile_DragEnter);
            // 
            // InputFileSelect
            // 
            this.InputFileSelect.Location = new System.Drawing.Point(488, 40);
            this.InputFileSelect.Name = "InputFileSelect";
            this.InputFileSelect.Size = new System.Drawing.Size(80, 24);
            this.InputFileSelect.TabIndex = 1;
            this.InputFileSelect.Text = "Select";
            this.InputFileSelect.UseVisualStyleBackColor = true;
            // 
            // OutputDir
            // 
            this.OutputDir.AllowDrop = true;
            this.OutputDir.Location = new System.Drawing.Point(12, 88);
            this.OutputDir.Name = "OutputDir";
            this.OutputDir.Size = new System.Drawing.Size(452, 19);
            this.OutputDir.TabIndex = 2;
            this.OutputDir.DragDrop += new System.Windows.Forms.DragEventHandler(this.OutputDir_DragDrop);
            this.OutputDir.DragEnter += new System.Windows.Forms.DragEventHandler(this.OutputDir_DragEnter);
            // 
            // OutputDirSelect
            // 
            this.OutputDirSelect.Location = new System.Drawing.Point(488, 88);
            this.OutputDirSelect.Name = "OutputDirSelect";
            this.OutputDirSelect.Size = new System.Drawing.Size(80, 24);
            this.OutputDirSelect.TabIndex = 3;
            this.OutputDirSelect.Text = "Select";
            this.OutputDirSelect.UseVisualStyleBackColor = true;
            // 
            // LF2CRLF
            // 
            this.LF2CRLF.AutoSize = true;
            this.LF2CRLF.Location = new System.Drawing.Point(16, 128);
            this.LF2CRLF.Name = "LF2CRLF";
            this.LF2CRLF.Size = new System.Drawing.Size(86, 16);
            this.LF2CRLF.TabIndex = 4;
            this.LF2CRLF.Text = "LF → CRLF";
            this.LF2CRLF.UseVisualStyleBackColor = true;
            // 
            // CRLF2LF
            // 
            this.CRLF2LF.AutoSize = true;
            this.CRLF2LF.Location = new System.Drawing.Point(120, 128);
            this.CRLF2LF.Name = "CRLF2LF";
            this.CRLF2LF.Size = new System.Drawing.Size(86, 16);
            this.CRLF2LF.TabIndex = 5;
            this.CRLF2LF.Text = "CRLF → LF";
            this.CRLF2LF.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "InputFilePath :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "OutputDirPath :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(626, 166);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CRLF2LF);
            this.Controls.Add(this.LF2CRLF);
            this.Controls.Add(this.OutputDirSelect);
            this.Controls.Add(this.OutputDir);
            this.Controls.Add(this.InputFileSelect);
            this.Controls.Add(this.InputFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputFile;
        private System.Windows.Forms.Button InputFileSelect;
        private System.Windows.Forms.TextBox OutputDir;
        private System.Windows.Forms.Button OutputDirSelect;
        private System.Windows.Forms.CheckBox LF2CRLF;
        private System.Windows.Forms.CheckBox CRLF2LF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

