using GlossaryLibary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlossaryForm
{
    public partial class FormAddWord : Form
    {

        public event EventHandler AddNewWordButtonClicked;
        public FormAddWord()
        {
            InitializeComponent();

            lbl_Language3.Hide();
            lbl_Language4.Hide();
            lbl_Language5.Hide();

            txtBox_addToFile.Text = FormCore.wordlist.Name + ".dat";


            try
            {
                switch (FormCore.wordlist.Languages.Count())
                {
                    case 2:
                        lbl_Language1.Text = FormCore.wordlist.Languages[0];
                        lbl_Language2.Text = FormCore.wordlist.Languages[1];
                        break;

                    case 3:
                        lbl_Language1.Text = FormCore.wordlist.Languages[0];
                        lbl_Language2.Text = FormCore.wordlist.Languages[1];
                        lbl_Language3.Text = FormCore.wordlist.Languages[2];
                        txtBox_Language3.Enabled = true;
                        lbl_Language3.Show();
                        break;

                    case 4:
                        lbl_Language1.Text = FormCore.wordlist.Languages[0];
                        lbl_Language2.Text = FormCore.wordlist.Languages[1];
                        lbl_Language3.Text = FormCore.wordlist.Languages[2];
                        lbl_Language4.Text = FormCore.wordlist.Languages[3];
                        txtBox_Language3.Enabled = true;
                        txtBox_Language4.Enabled = true;
                        lbl_Language3.Show();
                        lbl_Language4.Show();
                        break;

                    case 5:
                        lbl_Language1.Text = FormCore.wordlist.Languages[0];
                        lbl_Language2.Text = FormCore.wordlist.Languages[1];
                        lbl_Language3.Text = FormCore.wordlist.Languages[2];
                        lbl_Language4.Text = FormCore.wordlist.Languages[3];
                        lbl_Language5.Text = FormCore.wordlist.Languages[4];
                        txtBox_Language3.Enabled = true;
                        txtBox_Language4.Enabled = true;
                        txtBox_Language5.Enabled = true;
                        lbl_Language3.Show();
                        lbl_Language4.Show();
                        lbl_Language5.Show();
                        break;
                }
            }
            catch(NullReferenceException e)
            {
                MessageBox.Show(e.ToString());
            }
            

        }

        private void AddWordForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string[] words = new string[FormCore.wordlist.Languages.Length];
            int index = 0;

            foreach (TextBox tb in this.Controls.OfType<TextBox>().Reverse())
            {
                if (tb.Enabled && tb.Text != "")
                {
                    words[index] = tb.Text;
                    index++;
                }
                else if (tb.Enabled && tb.Text == "")
                {
                    MessageBox.Show("Error! wrong input!");

                    foreach (TextBox tbx in this.Controls.OfType<TextBox>())
                    {
                        tbx.Text = "";
                    }
                    
                    return;
                }
            }
           
            FormCore.wordlist.Add(words);
            FormCore.wordlist.Save();       

            txtBox_Language1.Text = "";
            txtBox_Language2.Text = "";
            txtBox_Language3.Text = "";
            txtBox_Language4.Text = "";
            txtBox_Language5.Text = "";

            if (AddNewWordButtonClicked != null)
            {
                this.AddNewWordButtonClicked(this, EventArgs.Empty);
            }

        }
    }
}
