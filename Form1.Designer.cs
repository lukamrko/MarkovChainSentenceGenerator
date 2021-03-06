namespace MarkovChainSentenceGenerator
{
    partial class MarcusChainSentenceGenerator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConan = new System.Windows.Forms.Button();
            this.textView = new System.Windows.Forms.TextBox();
            this.btnLovecraft = new System.Windows.Forms.Button();
            this.numWords = new System.Windows.Forms.NumericUpDown();
            this.lblNumberInfo = new System.Windows.Forms.Label();
            this.numSize = new System.Windows.Forms.NumericUpDown();
            this.lblFnt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numWords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConan
            // 
            this.btnConan.Location = new System.Drawing.Point(27, 49);
            this.btnConan.Name = "btnConan";
            this.btnConan.Size = new System.Drawing.Size(212, 51);
            this.btnConan.TabIndex = 0;
            this.btnConan.Text = "Generate Random Conan Text";
            this.btnConan.UseVisualStyleBackColor = true;
            this.btnConan.Click += new System.EventHandler(this.btnConan_Click);
            // 
            // textView
            // 
            this.textView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textView.BackColor = System.Drawing.SystemColors.Control;
            this.textView.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textView.Location = new System.Drawing.Point(27, 106);
            this.textView.Multiline = true;
            this.textView.Name = "textView";
            this.textView.ReadOnly = true;
            this.textView.Size = new System.Drawing.Size(1117, 599);
            this.textView.TabIndex = 1;
            // 
            // btnLovecraft
            // 
            this.btnLovecraft.Location = new System.Drawing.Point(245, 49);
            this.btnLovecraft.Name = "btnLovecraft";
            this.btnLovecraft.Size = new System.Drawing.Size(212, 51);
            this.btnLovecraft.TabIndex = 2;
            this.btnLovecraft.Text = "Generate Random Lovecraft Text";
            this.btnLovecraft.UseVisualStyleBackColor = true;
            this.btnLovecraft.Click += new System.EventHandler(this.btnLovecraft_Click);
            // 
            // numWords
            // 
            this.numWords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numWords.Location = new System.Drawing.Point(1074, 65);
            this.numWords.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numWords.Name = "numWords";
            this.numWords.Size = new System.Drawing.Size(70, 23);
            this.numWords.TabIndex = 3;
            this.numWords.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // lblNumberInfo
            // 
            this.lblNumberInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumberInfo.AutoSize = true;
            this.lblNumberInfo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNumberInfo.Location = new System.Drawing.Point(1074, 22);
            this.lblNumberInfo.Name = "lblNumberInfo";
            this.lblNumberInfo.Size = new System.Drawing.Size(65, 30);
            this.lblNumberInfo.TabIndex = 4;
            this.lblNumberInfo.Text = "Number of\r\nwords\r\n";
            this.lblNumberInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numSize
            // 
            this.numSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numSize.Location = new System.Drawing.Point(1012, 65);
            this.numSize.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numSize.Name = "numSize";
            this.numSize.Size = new System.Drawing.Size(56, 23);
            this.numSize.TabIndex = 5;
            this.numSize.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numSize.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // lblFnt
            // 
            this.lblFnt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFnt.AutoSize = true;
            this.lblFnt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFnt.Location = new System.Drawing.Point(1012, 30);
            this.lblFnt.Name = "lblFnt";
            this.lblFnt.Size = new System.Drawing.Size(56, 15);
            this.lblFnt.TabIndex = 6;
            this.lblFnt.Text = "Font size:";
            this.lblFnt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MarcusChainSentenceGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1156, 745);
            this.Controls.Add(this.lblFnt);
            this.Controls.Add(this.numSize);
            this.Controls.Add(this.lblNumberInfo);
            this.Controls.Add(this.numWords);
            this.Controls.Add(this.btnLovecraft);
            this.Controls.Add(this.textView);
            this.Controls.Add(this.btnConan);
            this.Name = "MarcusChainSentenceGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marcus Chain Sentence Generator";
            this.Load += new System.EventHandler(this.MarcusChainSentenceGenerator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numWords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnConan;
        private TextBox textView;
        private Button btnLovecraft;
        private NumericUpDown numWords;
        private Label lblNumberInfo;
        private NumericUpDown numSize;
        private Label lblFnt;
    }
}