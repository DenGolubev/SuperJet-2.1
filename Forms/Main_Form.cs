using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperJet_2._1.Forms
{
    public partial class Main_Form : Form
    {
        Form MDIForm = new isMDI_Form();
        User_Language language = new User_Language();
        

        public Main_Form()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MDIForm.Show();
            Hide();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            textBox1.GotFocus += TextBox1_GotFocus;
            textBox2.GotFocus += TextBox2_GotFocus;
        }

        private void TextBox2_GotFocus(object sender, EventArgs e)
        {
            language.input_US_language();
        }

        private void TextBox1_GotFocus(object sender, EventArgs e)
        {
            language.input_US_language();
        }
    }
}
