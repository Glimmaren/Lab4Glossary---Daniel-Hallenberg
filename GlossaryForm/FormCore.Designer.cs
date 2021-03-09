
namespace GlossaryForm
{
    partial class FormCore
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
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbx_Count = new System.Windows.Forms.TextBox();
            this.lstbox_Wordlists = new System.Windows.Forms.ListBox();
            this.lstbox_Words = new System.Windows.Forms.ListBox();
            this.chkbox_SortBy = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_AddWordlist = new System.Windows.Forms.Button();
            this.btn_Practice = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Add.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Image = global::GlossaryForm.Properties.Resources.add;
            this.btn_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Add.Location = new System.Drawing.Point(537, 270);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(173, 45);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "Add Word";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_remove.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove.Image = global::GlossaryForm.Properties.Resources.exit;
            this.btn_remove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_remove.Location = new System.Drawing.Point(537, 338);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(173, 45);
            this.btn_remove.TabIndex = 3;
            this.btn_remove.Text = "Remove Word";
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(42, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lists:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(208, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Words:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(24, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(409, 128);
            this.label3.TabIndex = 6;
            this.label3.Text = "Glossary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(372, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Word Count:";
            // 
            // txtbx_Count
            // 
            this.txtbx_Count.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtbx_Count.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbx_Count.Location = new System.Drawing.Point(396, 198);
            this.txtbx_Count.Name = "txtbx_Count";
            this.txtbx_Count.ReadOnly = true;
            this.txtbx_Count.Size = new System.Drawing.Size(71, 33);
            this.txtbx_Count.TabIndex = 8;
            // 
            // lstbox_Wordlists
            // 
            this.lstbox_Wordlists.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lstbox_Wordlists.FormattingEnabled = true;
            this.lstbox_Wordlists.ItemHeight = 15;
            this.lstbox_Wordlists.Location = new System.Drawing.Point(24, 195);
            this.lstbox_Wordlists.Name = "lstbox_Wordlists";
            this.lstbox_Wordlists.Size = new System.Drawing.Size(96, 259);
            this.lstbox_Wordlists.TabIndex = 9;
            this.lstbox_Wordlists.SelectedIndexChanged += new System.EventHandler(this.lstbox_Wordlists_SelectedIndexChanged);
            // 
            // lstbox_Words
            // 
            this.lstbox_Words.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lstbox_Words.FormattingEnabled = true;
            this.lstbox_Words.ItemHeight = 15;
            this.lstbox_Words.Location = new System.Drawing.Point(141, 195);
            this.lstbox_Words.Name = "lstbox_Words";
            this.lstbox_Words.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lstbox_Words.Size = new System.Drawing.Size(219, 259);
            this.lstbox_Words.TabIndex = 10;
            // 
            // chkbox_SortBy
            // 
            this.chkbox_SortBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.chkbox_SortBy.CheckOnClick = true;
            this.chkbox_SortBy.FormattingEnabled = true;
            this.chkbox_SortBy.Location = new System.Drawing.Point(372, 270);
            this.chkbox_SortBy.Name = "chkbox_SortBy";
            this.chkbox_SortBy.Size = new System.Drawing.Size(120, 184);
            this.chkbox_SortBy.TabIndex = 11;
            this.chkbox_SortBy.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chkbox_SortBy_ItemCheck);
            this.chkbox_SortBy.SelectedIndexChanged += new System.EventHandler(this.chkbox_SortBy_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(396, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "SortBy:";
            // 
            // btn_AddWordlist
            // 
            this.btn_AddWordlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_AddWordlist.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_AddWordlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddWordlist.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_AddWordlist.Image = global::GlossaryForm.Properties.Resources.add;
            this.btn_AddWordlist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddWordlist.Location = new System.Drawing.Point(537, 198);
            this.btn_AddWordlist.Name = "btn_AddWordlist";
            this.btn_AddWordlist.Size = new System.Drawing.Size(173, 45);
            this.btn_AddWordlist.TabIndex = 13;
            this.btn_AddWordlist.Text = "Add Wordlist";
            this.btn_AddWordlist.UseVisualStyleBackColor = false;
            this.btn_AddWordlist.Click += new System.EventHandler(this.btn_AddWordlist_Click);
            // 
            // btn_Practice
            // 
            this.btn_Practice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Practice.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Practice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Practice.Image = global::GlossaryForm.Properties.Resources.edit;
            this.btn_Practice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Practice.Location = new System.Drawing.Point(537, 409);
            this.btn_Practice.Name = "btn_Practice";
            this.btn_Practice.Size = new System.Drawing.Size(173, 45);
            this.btn_Practice.TabIndex = 14;
            this.btn_Practice.Text = "Practice";
            this.btn_Practice.UseVisualStyleBackColor = false;
            this.btn_Practice.Click += new System.EventHandler(this.btn_Practice_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GlossaryForm.Properties.Resources.glossary_icon100x100;
            this.pictureBox1.Location = new System.Drawing.Point(571, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 100);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // FormCore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(739, 523);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Practice);
            this.Controls.Add(this.btn_AddWordlist);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chkbox_SortBy);
            this.Controls.Add(this.lstbox_Words);
            this.Controls.Add(this.lstbox_Wordlists);
            this.Controls.Add(this.txtbx_Count);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_Add);
            this.Name = "FormCore";
            this.Text = "Glossary";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbx_Count;
        private System.Windows.Forms.ListBox lstbox_Wordlists;
        private System.Windows.Forms.CheckedListBox chkbox_SortBy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstbox_Words;
        private System.Windows.Forms.Button btn_AddWordlist;
        private System.Windows.Forms.Button btn_Practice;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}