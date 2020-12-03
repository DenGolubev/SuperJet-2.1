using System;
using System.Windows.Forms;
using SuperJet_2._1.Toolbox;

namespace SuperJet_2._1.Forms
{
    class Worcker_in: BaseForm
    {
        User_Language language = new User_Language();
        TextBox[] ArraytextBoxes = new TextBox[5];

        public Worcker_in()
        {
            InitializeComponent();

        }

        private void InitializeComponent()
        {
            MyHeight = 500;
            MyWidgth = 600;
            Create_MyForm();
            NameForm();
            GenerateLable();
            GenerateTextBox();
            Button button1 = GenerateButton();
            button1.Click += Button1_Click;
            
            
            this.Load += Worcker_in_Load;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            GeneratePassword();
        }

        private void Worcker_in_Load(object sender, System.EventArgs e)
        {
            language.input_RU_language();
        }

        private void NameForm()
        {
            My_Label nameFormLabel = new My_Label();
            nameFormLabel.X = 150;
            nameFormLabel.Y = 30;
            nameFormLabel.MyHeight = 30;
            nameFormLabel.MyWidgth = 300;
            nameFormLabel.Text = "Форма приема сотрудника";
            nameFormLabel.Create_MyLabel();
            Controls.Add(nameFormLabel);
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

        private Button GenerateButton()
        {
            My_Button button = new My_Button();
            button.MyHeight = 70;
            button.MyWidgth = 200;
            button.X = 190;
            button.Y = 370;
            button.Text = "Принять";
            button = (My_Button)button.Create_MyButton();
            Controls.Add(button);
            return button;
        }

        private void GeneratePassword()
        {
            My_Label Password = new My_Label();
            Password.X = 150;
            Password.Y = 300;
            Password.MyHeight = 30;
            Password.MyWidgth = 300;
            string passVol = ArraytextBoxes[0].Text + ArraytextBoxes[1].Text + ArraytextBoxes[2].Text;
            //Password.Text = ("Ваш пароль{0}", passVol.GetHashCode());
            Password.Create_MyLabel();
            Controls.Add(Password);
            
        }

    }
}
