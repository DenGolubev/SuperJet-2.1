using System;
using System.Windows.Forms;


namespace SuperJet_2._1.Forms
{
    partial class isMDI_Form
    {
        public isMDI_Form()
        {
            InitializeComponent();
        }
        private void IsMDI_Form_Click5(object sender, System.EventArgs e)
        {
            Worcker_out new_Worcker_out = new Worcker_out();
            new_Worcker_out.MdiParent = this;
            new_Worcker_out.Show();
        }

        private void IsMDI_Form_Click4(object sender, EventArgs e)
        {
            Worcker_in new_Worcker_in = new Worcker_in();
            new_Worcker_in.MdiParent = this;
            new_Worcker_in.Show();
        }

        private void IsMDI_Form_Click3(object sender, EventArgs e)
        {
            string my_Message = "Здесь должна быть форма KPI";
            MessageBox.Show(my_Message);
        }

        private void IsMDI_Form_Click2(object sender, EventArgs e)
        {
            string my_Message = "Вы пытаетесь сохранить файл";
            MessageBox.Show(my_Message);
        }

        private void IsMDI_Form_Click1(object sender, EventArgs e)
        {
            string my_Message = "Вы пытаетесь открыть файл";
            MessageBox.Show(my_Message);
        }

        private void IsMDI_Form_Click(object sender, EventArgs e)
        {
            string my_Message = "Вы пытаетесь создать файл";
            MessageBox.Show(my_Message);
        }

        private void IsMDI_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form Main_Form = new Main_Form();
            Main_Form.Show();
        }
    }
}
