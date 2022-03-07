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
            this.textView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
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
            // MarcusChainSentenceGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1156, 745);
            this.Controls.Add(this.textView);
            this.Controls.Add(this.btnConan);
            this.Name = "MarcusChainSentenceGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marcus Chain Sentence Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnConan;
        private TextBox textView;
    }
}