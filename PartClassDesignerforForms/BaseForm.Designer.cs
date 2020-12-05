using System.Windows.Forms;

namespace SuperJet_2._1.Forms
{
    partial class BaseForm: Form
    {
        //protected string message { get; set; }
        public int MyHeight { get; set; }
        public int MyWidgth { get; set; }

        private void InitializeComponent()
        {
            StartPosition = FormStartPosition.CenterParent;
        }

        protected void Create_MyForm()
        {
            Font = new System.Drawing.Font("Arial", 16);
            Size = new System.Drawing.Size(MyWidgth, MyHeight);
        }

        protected void showMessage(string new_message)
        {
           MessageBox.Show(new_message);
        }
    }
}
