
namespace GlossaryForm
{
    partial class Form2
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
            this.cmBox_NumOfLanguages = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBox_NameOfList = new System.Windows.Forms.TextBox();
            this.btn_OkAddNewList = new System.Windows.Forms.Button();
            this.txtBox_Language1 = new System.Windows.Forms.TextBox();
            this.txtBox_Language2 = new System.Windows.Forms.TextBox();
            this.txtBox_Language3 = new System.Windows.Forms.TextBox();
            this.txtBox_Language4 = new System.Windows.Forms.TextBox();
            this.txtBox_Language5 = new System.Windows.Forms.TextBox();
            this.lbl_Language1 = new System.Windows.Forms.Label();
            this.lbl_Language2 = new System.Windows.Forms.Label();
            this.lbl_Language3 = new System.Windows.Forms.Label();
            this.lbl_Language4 = new System.Windows.Forms.Label();
            this.lbl_Language5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(176, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New List";
            // 
            // cmBox_NumOfLanguages
            // 
            this.cmBox_NumOfLanguages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBox_NumOfLanguages.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmBox_NumOfLanguages.FormattingEnabled = true;
            this.cmBox_NumOfLanguages.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5"});
            this.cmBox_NumOfLanguages.Location = new System.Drawing.Point(38, 154);
            this.cmBox_NumOfLanguages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmBox_NumOfLanguages.Name = "cmBox_NumOfLanguages";
            this.cmBox_NumOfLanguages.Size = new System.Drawing.Size(79, 33);
            this.cmBox_NumOfLanguages.TabIndex = 1;
            this.cmBox_NumOfLanguages.SelectedIndexChanged += new System.EventHandler(this.cmBox_NumOfLanguages_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(34, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(393, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "How many languages should the list contain?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(38, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name of list?";
            // 
            // txtBox_NameOfList
            // 
            this.txtBox_NameOfList.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBox_NameOfList.Location = new System.Drawing.Point(38, 90);
            this.txtBox_NameOfList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBox_NameOfList.Name = "txtBox_NameOfList";
            this.txtBox_NameOfList.Size = new System.Drawing.Size(252, 32);
            this.txtBox_NameOfList.TabIndex = 4;
            // 
            // btn_OkAddNewList
            // 
            this.btn_OkAddNewList.Location = new System.Drawing.Point(380, 414);
            this.btn_OkAddNewList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_OkAddNewList.Name = "btn_OkAddNewList";
            this.btn_OkAddNewList.Size = new System.Drawing.Size(184, 53);
            this.btn_OkAddNewList.TabIndex = 5;
            this.btn_OkAddNewList.Text = "Save New List";
            this.btn_OkAddNewList.UseVisualStyleBackColor = true;
            this.btn_OkAddNewList.Click += new System.EventHandler(this.btn_OkAddNewList_Click);
            // 
            // txtBox_Language1
            // 
            this.txtBox_Language1.Enabled = false;
            this.txtBox_Language1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBox_Language1.Location = new System.Drawing.Point(34, 210);
            this.txtBox_Language1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBox_Language1.Name = "txtBox_Language1";
            this.txtBox_Language1.Size = new System.Drawing.Size(252, 32);
            this.txtBox_Language1.TabIndex = 6;
            // 
            // txtBox_Language2
            // 
            this.txtBox_Language2.Enabled = false;
            this.txtBox_Language2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBox_Language2.Location = new System.Drawing.Point(34, 265);
            this.txtBox_Language2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBox_Language2.Name = "txtBox_Language2";
            this.txtBox_Language2.Size = new System.Drawing.Size(252, 32);
            this.txtBox_Language2.TabIndex = 7;
            // 
            // txtBox_Language3
            // 
            this.txtBox_Language3.Enabled = false;
            this.txtBox_Language3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBox_Language3.Location = new System.Drawing.Point(34, 320);
            this.txtBox_Language3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBox_Language3.Name = "txtBox_Language3";
            this.txtBox_Language3.Size = new System.Drawing.Size(252, 32);
            this.txtBox_Language3.TabIndex = 8;
            // 
            // txtBox_Language4
            // 
            this.txtBox_Language4.Enabled = false;
            this.txtBox_Language4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBox_Language4.Location = new System.Drawing.Point(34, 379);
            this.txtBox_Language4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBox_Language4.Name = "txtBox_Language4";
            this.txtBox_Language4.Size = new System.Drawing.Size(252, 32);
            this.txtBox_Language4.TabIndex = 9;
            // 
            // txtBox_Language5
            // 
            this.txtBox_Language5.Enabled = false;
            this.txtBox_Language5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBox_Language5.Location = new System.Drawing.Point(34, 435);
            this.txtBox_Language5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBox_Language5.Name = "txtBox_Language5";
            this.txtBox_Language5.Size = new System.Drawing.Size(252, 32);
            this.txtBox_Language5.TabIndex = 10;
            // 
            // lbl_Language1
            // 
            this.lbl_Language1.AutoSize = true;
            this.lbl_Language1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Language1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_Language1.Location = new System.Drawing.Point(34, 189);
            this.lbl_Language1.Name = "lbl_Language1";
            this.lbl_Language1.Size = new System.Drawing.Size(80, 19);
            this.lbl_Language1.TabIndex = 12;
            this.lbl_Language1.Text = "Language1:";
            this.lbl_Language1.Click += new System.EventHandler(this.lbl_Language1_Click);
            // 
            // lbl_Language2
            // 
            this.lbl_Language2.AutoSize = true;
            this.lbl_Language2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Language2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_Language2.Location = new System.Drawing.Point(34, 244);
            this.lbl_Language2.Name = "lbl_Language2";
            this.lbl_Language2.Size = new System.Drawing.Size(80, 19);
            this.lbl_Language2.TabIndex = 13;
            this.lbl_Language2.Text = "Language2:";
            // 
            // lbl_Language3
            // 
            this.lbl_Language3.AutoSize = true;
            this.lbl_Language3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Language3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_Language3.Location = new System.Drawing.Point(34, 299);
            this.lbl_Language3.Name = "lbl_Language3";
            this.lbl_Language3.Size = new System.Drawing.Size(80, 19);
            this.lbl_Language3.TabIndex = 14;
            this.lbl_Language3.Text = "Language3:";
            // 
            // lbl_Language4
            // 
            this.lbl_Language4.AutoSize = true;
            this.lbl_Language4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Language4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_Language4.Location = new System.Drawing.Point(34, 354);
            this.lbl_Language4.Name = "lbl_Language4";
            this.lbl_Language4.Size = new System.Drawing.Size(80, 19);
            this.lbl_Language4.TabIndex = 15;
            this.lbl_Language4.Text = "Language4:";
            // 
            // lbl_Language5
            // 
            this.lbl_Language5.AutoSize = true;
            this.lbl_Language5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Language5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_Language5.Location = new System.Drawing.Point(34, 414);
            this.lbl_Language5.Name = "lbl_Language5";
            this.lbl_Language5.Size = new System.Drawing.Size(80, 19);
            this.lbl_Language5.TabIndex = 16;
            this.lbl_Language5.Text = "Language5:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(626, 483);
            this.Controls.Add(this.lbl_Language5);
            this.Controls.Add(this.lbl_Language4);
            this.Controls.Add(this.lbl_Language3);
            this.Controls.Add(this.lbl_Language2);
            this.Controls.Add(this.lbl_Language1);
            this.Controls.Add(this.txtBox_Language5);
            this.Controls.Add(this.txtBox_Language4);
            this.Controls.Add(this.txtBox_Language3);
            this.Controls.Add(this.txtBox_Language2);
            this.Controls.Add(this.txtBox_Language1);
            this.Controls.Add(this.btn_OkAddNewList);
            this.Controls.Add(this.txtBox_NameOfList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmBox_NumOfLanguages);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "OK";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmBox_NumOfLanguages;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBox_NameOfList;
        private System.Windows.Forms.Button btn_OkAddNewList;
        private System.Windows.Forms.TextBox txtBox_Language1;
        private System.Windows.Forms.TextBox txtBox_Language2;
        private System.Windows.Forms.TextBox txtBox_Language3;
        private System.Windows.Forms.TextBox txtBox_Language4;
        private System.Windows.Forms.TextBox txtBox_Language5;
        private System.Windows.Forms.Label lbl_Language1;
        private System.Windows.Forms.Label lbl_Language2;
        private System.Windows.Forms.Label lbl_Language3;
        private System.Windows.Forms.Label lbl_Language4;
        private System.Windows.Forms.Label lbl_Language5;
    }
}