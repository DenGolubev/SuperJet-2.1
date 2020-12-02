using System.Windows.Forms;
using SuperJet_2._1.Toolbox;

namespace SuperJet_2._1.Forms
{
    class Worcker_in: BaseForm
    {
        Label[] ArrayLabels = new Label[5];
        TextBox[] ArraytextBoxes = new TextBox[5];
        public Worcker_in()
        {
            MyHeight = 900;
            MyWidgth = 1200;
            Create_MyForm();
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            GenerateLable();
            GenerateTextBox();
        }

        private void GenerateLable()
        {
            for (int i = 0; i < 5; i++)
            {
                My_Label l_box = new My_Label();
                l_box.X = 30;
                l_box.Y = 50 + (i * 40);
                l_box.MyHeight = 30;
                l_box.MyWidgth = 200;
                Label newLabel = l_box.Create_MyLabel();
                newLabel.Name = "Label" + (i + 1);
                ArrayLabels[i] = newLabel;

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

        private void GenerateTextBox()
        {
            for (int i = 0; i < 5; i++)
            {
                My_TextBox t_box = new My_TextBox();
                t_box.X = 250;
                t_box.Y = 50 + (i * 40);
                t_box.MyHeight = 30;
                t_box.MyWidgth = 300;
                TextBox newTextbox = t_box.Create_MyTextbox();
                newTextbox.Name = "TextBox" + (i + 1);
                ArraytextBoxes[i] = t_box;
            }
            //
            //отрисовка textbox из массива на форме
            //
            foreach (TextBox textBox in ArraytextBoxes)
            {
                Controls.Add(textBox);
            }

            ArraytextBoxes[0].Text = "";
            ArraytextBoxes[1].Text = "";
            ArraytextBoxes[2].Text = "";
            ArraytextBoxes[3].Text = "";
            ArraytextBoxes[4].Text = "";
        }
    }
}
