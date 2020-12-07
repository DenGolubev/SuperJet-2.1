using System;
using System.Windows.Forms;
using SuperJet_2._1.Toolbox;

namespace SuperJet_2._1.Forms
{
    partial class LabourProtection: BaseForm
    {
        User_Language language = new User_Language();
        TextBox[] ArraytextBoxes = new TextBox[5];

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
            nameFormLabel.Create_MyLabel(100, 350, 200, 20, "Форма ввода данных сотрудника \nпо Охране Труда");
            Controls.Add(nameFormLabel);
        }

        protected void GenerateLable()
        {
            Label[] ArrayLabels = new Label[5];
            for (int i = 0; i < ArrayLabels.Length; i++)
            {
                My_Label l_box = new My_Label();
                l_box = (My_Label)l_box.Create_MyLabel(30, 200, 30, 100 + (i * 40), "Label" + (i + 1));
                ArrayLabels[i] = l_box;

            }
            //
            //отрисовка label из массива на форме
            //
            foreach (Label label in ArrayLabels)
            {
                Controls.Add(label);
            }

            ArrayLabels[0].Text = "Фамилия";
            ArrayLabels[1].Text = "Имя";
            ArrayLabels[2].Text = "Отчество";
            ArrayLabels[3].Text = "Табельный номер";
            ArrayLabels[4].Text = "E-Mail";
        }

        protected void GenerateTextBox()
        {

            for (int i = 0; i < ArraytextBoxes.Length; i++)
            {
                My_TextBox t_box = new My_TextBox();
                t_box.X = 250;
                t_box.Y = 100 + (i * 40);
                t_box.MyHeight = 30;
                t_box.MyWidgth = 300;
                t_box.Name = "TextBox" + (i + 1);
                t_box = (My_TextBox)t_box.Create_MyTextbox();
                ArraytextBoxes[i] = t_box;
            }
            //
            //отрисовка textbox из массива на форме
            //
            foreach (TextBox textBox in ArraytextBoxes)
            {
                Controls.Add(textBox);
            }

        }

        protected Button GenerateButton()
        {
            My_Button button = new My_Button();
            button = (My_Button)button.Create_MyButton(70, 200, 190, 370, "Принять");
            Controls.Add(button);
            return button;
        }
    }
}
