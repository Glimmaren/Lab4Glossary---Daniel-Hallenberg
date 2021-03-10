
namespace GlossaryForm
{
    partial class FormRemoveWord
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
            this.btn_RemoveWord = new System.Windows.Forms.Button();
            this.lbl_Language2 = new System.Windows.Forms.Label();
            this.lbl_Language = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBox_Language = new System.Windows.Forms.ComboBox();
            this.cmbBox_word = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_RemoveWord
            // 
            this.btn_RemoveWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_RemoveWord.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_RemoveWord.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_RemoveWord.Image = global::GlossaryForm.Properties.Resources.exit;
            this.btn_RemoveWord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_RemoveWord.Location = new System.Drawing.Point(112, 263);
            this.btn_RemoveWord.Name = "btn_RemoveWord";
            this.btn_RemoveWord.Size = new System.Drawing.Size(154, 49);
            this.btn_RemoveWord.TabIndex = 23;
            this.btn_RemoveWord.Text = "Remove";
            this.btn_RemoveWord.UseVisualStyleBackColor = false;
            this.btn_RemoveWord.Click += new System.EventHandler(this.btn_RemoveWord_Click);
            // 
            // lbl_Language2
            // 
            this.lbl_Language2.AutoSize = true;
            this.lbl_Language2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Language2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_Language2.Location = new System.Drawing.Point(12, 160);
            this.lbl_Language2.Name = "lbl_Language2";
            this.lbl_Language2.Size = new System.Drawing.Size(155, 25);
            this.lbl_Language2.TabIndex = 14;
            this.lbl_Language2.Text = "Word to Remove:";
            // 
            // lbl_Language
            // 
            this.lbl_Language.AutoSize = true;
            this.lbl_Language.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Language.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_Language.Location = new System.Drawing.Point(12, 96);
            this.lbl_Language.Name = "lbl_Language";
            this.lbl_Language.Size = new System.Drawing.Size(99, 25);
            this.lbl_Language.TabIndex = 13;
            this.lbl_Language.Text = "Language:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(112, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 40);
            this.label1.TabIndex = 12;
            this.label1.Text = "Remove Word";
            // 
            // cmbBox_Language
            // 
            this.cmbBox_Language.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbBox_Language.FormattingEnabled = true;
            this.cmbBox_Language.Location = new System.Drawing.Point(12, 124);
            this.cmbBox_Language.Name = "cmbBox_Language";
            this.cmbBox_Language.Size = new System.Drawing.Size(173, 33);
            this.cmbBox_Language.TabIndex = 24;
            this.cmbBox_Language.SelectedIndexChanged += new System.EventHandler(this.cmbBox_Language_SelectedIndexChanged);
            // 
            // cmbBox_word
            // 
            this.cmbBox_word.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbBox_word.FormattingEnabled = true;
            this.cmbBox_word.Location = new System.Drawing.Point(12, 188);
            this.cmbBox_word.Name = "cmbBox_word";
            this.cmbBox_word.Size = new System.Drawing.Size(173, 33);
            this.cmbBox_word.TabIndex = 25;
            // 
            // RemoveWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(408, 363);
            this.Controls.Add(this.cmbBox_word);
            this.Controls.Add(this.cmbBox_Language);
            this.Controls.Add(this.btn_RemoveWord);
            this.Controls.Add(this.lbl_Language2);
            this.Controls.Add(this.lbl_Language);
            this.Controls.Add(this.label1);
            this.Name = "RemoveWord";
            this.Text = "Remove Word";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_RemoveWord;
        private System.Windows.Forms.Label lbl_Language2;
        private System.Windows.Forms.Label lbl_Language;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBox_Language;
        private System.Windows.Forms.ComboBox cmbBox_word;
    }
}