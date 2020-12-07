using System;
using System.Windows.Forms;
using SuperJet_2._1.Toolbox;

namespace SuperJet_2._1.Forms
{
    partial class Worcker_out: BaseForm
    {
        User_Language language = new User_Language();
        TextBox[] ArraytextBoxes = new TextBox[5];

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
            nameFormLabel.Create_MyLabel(30, 350, 120, 30, "Форма увольнения сотрудника");
            Controls.Add(nameFormLabel);
        }

        protected void CreateLable()
        {
            My_Label l_box = new My_Label();
            l_box = (My_Label)l_box.Create_MyLabel(30, 250, 20, 100, "Уволить сотрудника:");
            Controls.Add(l_box);
        }   

        protected void CreateCombobox()
        {
            My_Combobox c_box = new My_Combobox();
            c_box = (My_Combobox)c_box.Create_MyCombobox(30, 280, 280, 100);
            Controls.Add(c_box);
        }

        protected Button CreateButton()
        {
            My_Button button = new My_Button();
            button = (My_Button)button.Create_MyButton(70, 200, 190, 170, "Уволить");
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
