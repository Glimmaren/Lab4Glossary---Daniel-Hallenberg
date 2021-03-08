
namespace GlossaryForm
{
    partial class ManageForm
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
            this.SuspendLayout();
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(529, 95);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(173, 45);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "Add Word";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(529, 161);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(173, 45);
            this.btn_remove.TabIndex = 3;
            this.btn_remove.Text = "Remove Word";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(32, 70);
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
            this.label2.Location = new System.Drawing.Point(198, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Words:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(221, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 45);
            this.label3.TabIndex = 6;
            this.label3.Text = "Manage Wordlists";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(362, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Word Count:";
            // 
            // txtbx_Count
            // 
            this.txtbx_Count.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbx_Count.Location = new System.Drawing.Point(386, 99);
            this.txtbx_Count.Name = "txtbx_Count";
            this.txtbx_Count.ReadOnly = true;
            this.txtbx_Count.Size = new System.Drawing.Size(71, 33);
            this.txtbx_Count.TabIndex = 8;
            // 
            // lstbox_Wordlists
            // 
            this.lstbox_Wordlists.FormattingEnabled = true;
            this.lstbox_Wordlists.ItemHeight = 15;
            this.lstbox_Wordlists.Location = new System.Drawing.Point(14, 96);
            this.lstbox_Wordlists.Name = "lstbox_Wordlists";
            this.lstbox_Wordlists.Size = new System.Drawing.Size(96, 259);
            this.lstbox_Wordlists.TabIndex = 9;
            this.lstbox_Wordlists.SelectedIndexChanged += new System.EventHandler(this.lstbox_Wordlists_SelectedIndexChanged);
            // 
            // lstbox_Words
            // 
            this.lstbox_Words.FormattingEnabled = true;
            this.lstbox_Words.ItemHeight = 15;
            this.lstbox_Words.Location = new System.Drawing.Point(131, 96);
            this.lstbox_Words.Name = "lstbox_Words";
            this.lstbox_Words.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lstbox_Words.Size = new System.Drawing.Size(219, 259);
            this.lstbox_Words.TabIndex = 10;
            // 
            // chkbox_SortBy
            // 
            this.chkbox_SortBy.CheckOnClick = true;
            this.chkbox_SortBy.FormattingEnabled = true;
            this.chkbox_SortBy.Location = new System.Drawing.Point(362, 171);
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
            this.label5.Location = new System.Drawing.Point(386, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "SortBy:";
            // 
            // ManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 523);
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
            this.Name = "ManageForm";
            this.Text = "Manage";
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
    }
}