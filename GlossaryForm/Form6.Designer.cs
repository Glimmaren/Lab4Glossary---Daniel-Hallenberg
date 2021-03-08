
namespace GlossaryForm
{
    partial class PracticeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_FromLanguage = new System.Windows.Forms.Label();
            this.lbl_ToLanguage = new System.Windows.Forms.Label();
            this.lbl_GlossWord = new System.Windows.Forms.Label();
            this.txtBox_UserWord = new System.Windows.Forms.TextBox();
            this.lbl_CorrectInCorrect = new System.Windows.Forms.Label();
            this.btn_guess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(176, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Practice Glossary";
            // 
            // lbl_FromLanguage
            // 
            this.lbl_FromLanguage.AutoSize = true;
            this.lbl_FromLanguage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_FromLanguage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_FromLanguage.Location = new System.Drawing.Point(264, 107);
            this.lbl_FromLanguage.Name = "lbl_FromLanguage";
            this.lbl_FromLanguage.Size = new System.Drawing.Size(63, 25);
            this.lbl_FromLanguage.TabIndex = 1;
            this.lbl_FromLanguage.Text = "label2";
            // 
            // lbl_ToLanguge
            // 
            this.lbl_ToLanguage.AutoSize = true;
            this.lbl_ToLanguage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ToLanguage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_ToLanguage.Location = new System.Drawing.Point(264, 229);
            this.lbl_ToLanguage.Name = "lbl_ToLanguge";
            this.lbl_ToLanguage.Size = new System.Drawing.Size(63, 25);
            this.lbl_ToLanguage.TabIndex = 2;
            this.lbl_ToLanguage.Text = "label2";
            // 
            // lbl_GlossWord
            // 
            this.lbl_GlossWord.AutoSize = true;
            this.lbl_GlossWord.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_GlossWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_GlossWord.Location = new System.Drawing.Point(248, 132);
            this.lbl_GlossWord.Name = "lbl_GlossWord";
            this.lbl_GlossWord.Size = new System.Drawing.Size(94, 40);
            this.lbl_GlossWord.TabIndex = 3;
            this.lbl_GlossWord.Text = "label2";
            // 
            // txtBox_UserWord
            // 
            this.txtBox_UserWord.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBox_UserWord.Location = new System.Drawing.Point(198, 257);
            this.txtBox_UserWord.Name = "txtBox_UserWord";
            this.txtBox_UserWord.Size = new System.Drawing.Size(187, 39);
            this.txtBox_UserWord.TabIndex = 4;
            // 
            // lbl_CorrectInCorrect
            // 
            this.lbl_CorrectInCorrect.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_CorrectInCorrect.AutoSize = true;
            this.lbl_CorrectInCorrect.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_CorrectInCorrect.Location = new System.Drawing.Point(252, 182);
            this.lbl_CorrectInCorrect.Name = "lbl_CorrectInCorrect";
            this.lbl_CorrectInCorrect.Size = new System.Drawing.Size(0, 37);
            this.lbl_CorrectInCorrect.TabIndex = 5;
            // 
            // btn_guess
            // 
            this.btn_guess.Location = new System.Drawing.Point(224, 349);
            this.btn_guess.Name = "btn_guess";
            this.btn_guess.Size = new System.Drawing.Size(135, 54);
            this.btn_guess.TabIndex = 6;
            this.btn_guess.Text = "Guess!";
            this.btn_guess.UseVisualStyleBackColor = true;
            this.btn_guess.Click += new System.EventHandler(this.btn_guess_Click);
            // 
            // PracticeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 447);
            this.Controls.Add(this.btn_guess);
            this.Controls.Add(this.lbl_CorrectInCorrect);
            this.Controls.Add(this.txtBox_UserWord);
            this.Controls.Add(this.lbl_GlossWord);
            this.Controls.Add(this.lbl_ToLanguage);
            this.Controls.Add(this.lbl_FromLanguage);
            this.Controls.Add(this.label1);
            this.Name = "PracticeForm";
            this.Text = "Form6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_FromLanguage;
        private System.Windows.Forms.Label lbl_ToLanguage;
        private System.Windows.Forms.Label lbl_GlossWord;
        private System.Windows.Forms.TextBox txtBox_UserWord;
        private System.Windows.Forms.Label lbl_CorrectInCorrect;
        private System.Windows.Forms.Button btn_guess;
    }
}