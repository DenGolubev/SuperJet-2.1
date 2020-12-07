using System.Windows.Forms;


namespace SuperJet_2._1.Forms
{
    partial class FileDownload
    {
        Button Button1 = new Button();
        Label Label1 = new Label();

        public FileDownload()
        {
            InitializeComponent();
            Button1 = GenerateButton();
            Button1.Click += Button1_Click;
            Label1 = CreateLabel();
            

        }

        private void Button1_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                FilePath = openFile.FileName;
                Label1.Text = FilePath;
            }
        }
    }
}
