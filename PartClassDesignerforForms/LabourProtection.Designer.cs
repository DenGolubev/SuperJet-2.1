using System;
using System.Windows.Forms;
using SuperJet_2._1.Toolbox;

namespace SuperJet_2._1.Forms
{
    partial class LabourProtection: BaseForm
    {
        private readonly string nameFormLabeltext = "Форма ввода данных сотрудника \nпо Охране Труда";
        private void InitializeComponent()
        {
            MyHeight = 600;
            MyWidgth = 800;
            Create_MyForm();
            NameFormLable();
        }

        protected void NameFormLable()
        {
            My_Label nameFormLabel = new My_Label();
            nameFormLabel.X = 200;
            nameFormLabel.Y = 20;
            nameFormLabel.MyHeight = 100;
            nameFormLabel.MyWidgth = 350;
            nameFormLabel.Text = nameFormLabeltext;
            nameFormLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            nameFormLabel.Create_MyLabel();
            Controls.Add(nameFormLabel);
        }
    }
}
