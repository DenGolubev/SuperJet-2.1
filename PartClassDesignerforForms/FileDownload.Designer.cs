using System.Windows.Forms;
using SuperJet_2._1.Toolbox;

namespace SuperJet_2._1.Forms
{
    partial class FileDownload: BaseForm
    {
        string FilePath { get; set; }

        protected void InitializeComponent()
        {
            MyHeight = 600;
            MyWidgth = 800;
            Text = "Форма загрузки файла";
            Create_MyForm();
            NameFormLable();
        }

        private void NameFormLable()
        {
            My_Label nameFormLabel = new My_Label();
            nameFormLabel.Create_MyLabel(30, 300, 230, 30, "Форма загрузки файла");
            Controls.Add(nameFormLabel);
        }

        private Label CreateLabel()
        {
            My_Label label = new My_Label();
            label = (My_Label)label.Create_MyLabel(30, 400, 30, 100, null);
            Controls.Add(label);
            return label;
        }

        private Button GenerateButton()
        {
            My_Button button = new My_Button();
            button = (My_Button)button.Create_MyButton(70, 200, 190, 370, "Выбрать файл");
            Controls.Add(button);
            return button;
        }

    }
}
