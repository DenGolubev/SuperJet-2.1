using System.Windows.Forms;

namespace SuperJet_2._1.Forms
{
    class BaseForm: Form
    {
        public int MyHeight { get; set; }
        public int MyWidgth { get; set; }

        public void Create_MyForm()
        {
            Font = new System.Drawing.Font("Arial", 16);
            Size = new System.Drawing.Size(MyWidgth, MyHeight);
            StartPosition = FormStartPosition.CenterParent;
            
        }
    }
}
