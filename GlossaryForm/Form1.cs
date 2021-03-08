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
    
    public partial class Form1 : Form
    {
        public static string[] PopulateList()
        {
            string[] list = Wordlist.GetLists();

            return list;
        }
        public Form1()
        {
            InitializeComponent();

            lstbox_WordLists.DataSource = PopulateList();
        }

        private void lstbox_WordLists_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_newList_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            form2.Show();
        }

        private void btn_ManageLists_Click(object sender, EventArgs e)
        {
            ManageForm manageForm = new ManageForm();

            manageForm.Show();
        }
    }
}
