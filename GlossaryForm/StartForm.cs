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
    
    public partial class MainForm : Form
    {


        public static string[] PopulateList()
        {
            string[] list = Wordlist.GetLists();

            return list;
        }
        public MainForm()
        {
            InitializeComponent();
        }

        private void lstbox_WordLists_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void btn_Start_Click(object sender, EventArgs e)
        {
            FormCore coreForm = new FormCore();

            coreForm.Show();
        }


    }
}
