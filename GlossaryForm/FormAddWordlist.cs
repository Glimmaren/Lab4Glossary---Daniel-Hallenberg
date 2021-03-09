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
    public partial class FormAddWordlist : Form
    {
        public event EventHandler AddNewListButtonClicked;
        public FormAddWordlist()
        {
            InitializeComponent();
            
        }

        private void btn_OkAddNewList_Click(object sender, EventArgs e) // Här finns
        {
            
            if (txtBox_NameOfList.Text != "" && cmBox_NumOfLanguages.SelectedItem != null) 
            {
                int numOfLanguages = Convert.ToInt32(cmBox_NumOfLanguages.SelectedItem.ToString()) + 1;
                string[] txtBoxInput = new string[numOfLanguages];
                string[] languages;
                string name;
                int i = 0;

                foreach (TextBox tb in this.Controls.OfType<TextBox>())
                {
                    if (tb.Enabled && tb.Text != "")
                    {
                        txtBoxInput[i] = tb.Text;
                        i++;
                    }
                    else if(tb.Enabled && tb.Text == "")
                    {
                        MessageBox.Show("Error! wrong input!");

                        foreach (TextBox tbx in this.Controls.OfType<TextBox>())
                        {
                            tbx.Text = "";
                            tbx.Enabled = false;
                        }
                        txtBox_NameOfList.Enabled = true;
                        return;
                    }
                }

                var txtBoxInboxReverse = txtBoxInput.Reverse().ToArray();
                name = txtBoxInboxReverse[0];
                languages = txtBoxInboxReverse.Skip(1).ToArray();

                Wordlist wordlist = new Wordlist(name, languages);

                wordlist.Save();

                if(this.AddNewListButtonClicked != null)
                {
                    this.AddNewListButtonClicked(this, EventArgs.Empty); // kolla på detta
                }
                       

                foreach (TextBox tb in this.Controls.OfType<TextBox>())
                {
                    tb.Text = "";
                    tb.Enabled = false;
                }
                txtBox_NameOfList.Enabled = true;
            }
            else
            {            
                MessageBox.Show("Error! wrong input!");
                foreach (TextBox tb in this.Controls.OfType<TextBox>())
                {
                    
                    tb.Text = "";
                    tb.Enabled = false;
                }
                txtBox_NameOfList.Enabled = true;
            }



        }

        private void lbl_Language1_Click(object sender, EventArgs e)
        {

        }

        private void cmBox_NumOfLanguages_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmBox_NumOfLanguages.SelectedItem.ToString())
            {
                case "2": 
                    txtBox_Language1.Enabled = true;                          
                    txtBox_Language2.Enabled = true; break;

                case "3":
                    txtBox_Language1.Enabled = true;
                    txtBox_Language2.Enabled = true;
                    txtBox_Language3.Enabled = true; break;

                case "4":
                    txtBox_Language1.Enabled = true;
                    txtBox_Language2.Enabled = true;
                    txtBox_Language3.Enabled = true;
                    txtBox_Language4.Enabled = true; break;

                case "5":
                    txtBox_Language1.Enabled = true;
                    txtBox_Language2.Enabled = true;
                    txtBox_Language3.Enabled = true;
                    txtBox_Language4.Enabled = true;
                    txtBox_Language5.Enabled = true; break;
            }
        }
      
    }
}
