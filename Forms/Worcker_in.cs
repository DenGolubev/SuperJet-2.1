using System.Windows.Forms;
using SuperJet_2._1.Toolbox;

namespace SuperJet_2._1.Forms
{
    class Worcker_in: BaseForm
    {       
        public Worcker_in()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            MyHeight = 900;
            MyWidgth = 1200;
            Create_MyForm();
            GenerateLable();
            GenerateTextBox();
            GenerateButton();
        }

        private void GenerateLable()
        {
            Label[] ArrayLabels = new Label[5];
            for (int i = 0; i < ArrayLabels.Length; i++)
            {
                My_Label l_box = new My_Label();
                l_box.X = 30;
                l_box.Y = 100 + (i * 40);
                l_box.MyHeight = 30;
                l_box.MyWidgth = 200;
                l_box.Name = "Label" + (i + 1);
                l_box = (My_Label)l_box.Create_MyLabel();
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

        private void GenerateTextBox()
        {
            TextBox[] ArraytextBoxes = new TextBox[5];
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

            ArraytextBoxes[0].Text = "";
            ArraytextBoxes[1].Text = "";
            ArraytextBoxes[2].Text = "";
            ArraytextBoxes[3].Text = "";
            ArraytextBoxes[4].Text = "";
        }

        private void GenerateButton()
        {
            My_Button button = new My_Button();
            button.MyHeight = 70;
            button.MyWidgth = 200;
            button.X = 30;
            button.Y = 730;
            button.Text = "Принять";
            button = (My_Button)button.Create_MyButton();
            Controls.Add(button);
        }
    }
}
