using System;
using System.Windows.Forms;
using SuperJet_2._1.Toolbox;

namespace SuperJet_2._1.Forms
{

    partial class Worcker_in: BaseForm
    {
        User_Language language = new User_Language();
        TextBox[] ArraytextBoxes = new TextBox[5];
        private readonly string nameFormLabeltext = "Форма приема сотрудника";

        private void InitializeComponent()
        {
            MyHeight = 500;
            MyWidgth = 600;
            Text = "Форма приема сотрудника";
            WindowState = FormWindowState.Normal;
            Create_MyForm();
            NameFormLable();
            GenerateLable();
            GenerateTextBox();
            Button button1 = GenerateButton();
            button1.Click += Button1_Click;
            this.Load += Worcker_in_Load;
        }

        protected void NameFormLable()
        {
            My_Label nameFormLabel = new My_Label();
            nameFormLabel.X = 150;
            nameFormLabel.Y = 30;
            nameFormLabel.MyHeight = 30;
            nameFormLabel.MyWidgth = 300;
            nameFormLabel.Text = nameFormLabeltext;
            nameFormLabel.Create_MyLabel();
            Controls.Add(nameFormLabel);
        }

        protected void GenerateLable()
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
            button.MyHeight = 70;
            button.MyWidgth = 200;
            button.X = 190;
            button.Y = 370;
            button.Text = "Принять";
            button = (My_Button)button.Create_MyButton();
            Controls.Add(button);
            return button;
        }

        protected void GeneratePassword()
        {
            My_Label Password = new My_Label();
            Password.X = 30;
            Password.Y = 340;
            Password.MyHeight = 30;
            Password.MyWidgth = 300;
            string passVol = ArraytextBoxes[0].Text + ArraytextBoxes[1].Text + ArraytextBoxes[2].Text + ArraytextBoxes[3].Text;
            Password.Text = "Ваш пароль: " + passVol.GetHashCode();
            Password.Create_MyLabel();
            Controls.Add(Password);

        }

        protected void GenerateLogin()
        {
            My_Label Login = new My_Label();
            Login.X = 30;
            Login.Y = 300;
            Login.MyHeight = 30;
            Login.MyWidgth = 400;
            Login.Text = "Ваш логин: " + Translit(ArraytextBoxes[0].Text);
            Login.Create_MyLabel();
            Controls.Add(Login);

        }

        public string Translit(string login)
        {
            string myLog = null;
            string trans_lit = login;
            trans_lit = trans_lit.ToUpper();
            char[] loginArray = trans_lit.ToCharArray();
            string[] rus = {"А","Б","В","Г","Д","Е","Ё","Ж", "З","И","Й","К","Л","М", "Н",
          "О","П","Р","С","Т","У","Ф","Х", "Ц", "Ч", "Ш", "Щ",   "Ъ", "Ы","Ь",
          "Э","Ю", "Я" };
            string[] eng = {"A","B","V","G","D","E","E","ZH","Z","I","Y","K","L","M","N",
          "O","P","R","S","T","U","F","KH","TS","CH","SH","SHCH",null,"Y",null,
          "E","YU","YA"};
            for (int i = 0; i < loginArray.Length; i++)
            {
                for (int y = 0; y < rus.Length; y++)
                {
                    if (Convert.ToString(loginArray[i]) == rus[y])
                    {

                        myLog += eng[y];
                        break;
                    }
                }
            }

            return myLog;
        }

    }
}
