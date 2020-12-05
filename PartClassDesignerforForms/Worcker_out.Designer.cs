using System;
using System.Windows.Forms;
using SuperJet_2._1.Toolbox;

namespace SuperJet_2._1.Forms
{
    partial class Worcker_out: BaseForm
    {
        User_Language language = new User_Language();
        TextBox[] ArraytextBoxes = new TextBox[5];

        private readonly string nameFormLabeltext = "Форма увольнения сотрудника";

        private void InitializeComponent()
        {
            MyHeight = 300;
            MyWidgth = 600;
            Text = "Форма увольнения сотрудника";
            Create_MyForm();
            NameFormLable();
            CreateLable();
            CreateCombobox();
            Button button1 = CreateButton();
            button1.Click += Button1_Click;
        }

        protected void NameFormLable()
        {
            My_Label nameFormLabel = new My_Label();
            nameFormLabel.X = 120;
            nameFormLabel.Y = 30;
            nameFormLabel.MyHeight = 30;
            nameFormLabel.MyWidgth = 350;
            nameFormLabel.Text = nameFormLabeltext;
            nameFormLabel.Create_MyLabel();
            Controls.Add(nameFormLabel);
        }

        protected void CreateLable()
        {
            My_Label l_box = new My_Label();
            l_box.X = 20;
            l_box.Y = 100;
            l_box.MyHeight = 30;
            l_box.MyWidgth = 250;
            l_box.Text = "Уволить сотрудника:";
            l_box = (My_Label)l_box.Create_MyLabel();
            Controls.Add(l_box);
        }   

        protected void CreateCombobox()
        {
            My_Combobox c_box = new My_Combobox();
            c_box.X = 280;
            c_box.Y = 100;
            c_box.MyHeight = 30;
            c_box.MyWidgth = 280;
            c_box = (My_Combobox)c_box.Create_MyCombobox();
            Controls.Add(c_box);
        }

        protected Button CreateButton()
        {
            My_Button button = new My_Button();
            button.MyHeight = 70;
            button.MyWidgth = 200;
            button.X = 190;
            button.Y = 170;
            button.Text = "Уволить";
            button = (My_Button)button.Create_MyButton();
            Controls.Add(button);
            return button;
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
