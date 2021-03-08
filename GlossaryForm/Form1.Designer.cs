
namespace GlossaryForm
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_newList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstbox_WordLists = new System.Windows.Forms.ListBox();
            this.btn_ManageLists = new System.Windows.Forms.Button();
            this.btn_Practice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GlossaryForm.Properties.Resources.glossary_icon;
            this.pictureBox1.Location = new System.Drawing.Point(84, 94);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 249);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_newList
            // 
            this.btn_newList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_newList.Location = new System.Drawing.Point(584, 94);
            this.btn_newList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_newList.Name = "btn_newList";
            this.btn_newList.Size = new System.Drawing.Size(178, 44);
            this.btn_newList.TabIndex = 1;
            this.btn_newList.Text = "New WordList";
            this.btn_newList.UseVisualStyleBackColor = false;
            this.btn_newList.Click += new System.EventHandler(this.btn_newList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(214, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome to Glossary";
            // 
            // lstbox_WordLists
            // 
            this.lstbox_WordLists.FormattingEnabled = true;
            this.lstbox_WordLists.ItemHeight = 15;
            this.lstbox_WordLists.Location = new System.Drawing.Point(347, 94);
            this.lstbox_WordLists.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstbox_WordLists.Name = "lstbox_WordLists";
            this.lstbox_WordLists.Size = new System.Drawing.Size(204, 199);
            this.lstbox_WordLists.TabIndex = 3;
            this.lstbox_WordLists.SelectedIndexChanged += new System.EventHandler(this.lstbox_WordLists_SelectedIndexChanged);
            // 
            // btn_ManageLists
            // 
            this.btn_ManageLists.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_ManageLists.Location = new System.Drawing.Point(584, 170);
            this.btn_ManageLists.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ManageLists.Name = "btn_ManageLists";
            this.btn_ManageLists.Size = new System.Drawing.Size(178, 44);
            this.btn_ManageLists.TabIndex = 4;
            this.btn_ManageLists.Text = "Manage WordLists";
            this.btn_ManageLists.UseVisualStyleBackColor = false;
            this.btn_ManageLists.Click += new System.EventHandler(this.btn_ManageLists_Click);
            // 
            // btn_Practice
            // 
            this.btn_Practice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Practice.Location = new System.Drawing.Point(584, 248);
            this.btn_Practice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Practice.Name = "btn_Practice";
            this.btn_Practice.Size = new System.Drawing.Size(178, 44);
            this.btn_Practice.TabIndex = 5;
            this.btn_Practice.Text = "Practice";
            this.btn_Practice.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 530);
            this.Controls.Add(this.btn_Practice);
            this.Controls.Add(this.btn_ManageLists);
            this.Controls.Add(this.lstbox_WordLists);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_newList);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_newList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstbox_WordLists;
        private System.Windows.Forms.Button btn_ManageLists;
        private System.Windows.Forms.Button btn_Practice;
    }
}

