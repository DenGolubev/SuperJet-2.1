using System;
using System.Windows.Forms;

namespace SuperJet_2._1.Forms
{
    partial class Worcker_in
    {
        public Worcker_in()
        {
            InitializeComponent();
        }
                
        private void Button1_Click(object sender, EventArgs e)
        {
            GenerateLogin();
            GeneratePassword();
        }
        private void Worcker_in_Load(object sender, System.EventArgs e)
        {
            language.input_RU_language();
        }
    }
}
