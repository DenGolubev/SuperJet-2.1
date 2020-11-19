using System;
using System.Windows.Forms;
using SuperJet_2._1.Forms;

namespace SuperJet_2._1
{
    public partial class Main_Form : Form
    {
        MDI_Form my_Mdi_form = new MDI_Form();
        User_Language language = new User_Language();
        
        public Main_Form()
        {  
            InitializeComponent();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
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

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            my_Mdi_form.Show();
        }
    }
}
