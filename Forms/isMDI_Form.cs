using System.Windows.Forms;


namespace SuperJet_2._1.Forms
{
    class isMDI_Form: BaseForm
    {
        MenuStrip menu_Strip = new MenuStrip();

        public isMDI_Form()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            IsMdiContainer = true;
            FormClosing += IsMDI_Form_FormClosing;
            Controls.Add(menu_Strip);
        }

        private void InitializeComponent()
        {
            menu_Strip = myMenuStrip();
        }

        protected MenuStrip myMenuStrip()
        {
            // 
            // ToolStripMenuItem
            // 
            ToolStripMenuItem menuItem, menuItem1;
            menuItem = new ToolStripMenuItem("Файл");
            menuItem.DropDownItems.Add("Создать").Click += IsMDI_Form_Click; ;
            menuItem.DropDownItems.Add("Открыть").Click += IsMDI_Form_Click1; ;
            menuItem.DropDownItems.Add("Сохранить").Click += IsMDI_Form_Click2;
            menuItem1 = new ToolStripMenuItem("Отчеты");
            menuItem1.DropDownItems.Add("Создать").Click += IsMDI_Form_Click3; ;
            menuItem1.DropDownItems.Add("Отправить");

            // 
            // menuStrip
            // 
            menu_Strip.Font = new System.Drawing.Font("Arial", 16);
            menu_Strip.Location = new System.Drawing.Point(0, 0);
            menu_Strip.Name = "menuStrip";
            menu_Strip.Size = new System.Drawing.Size(800, 24);
            menu_Strip.TabIndex = 0;
            menu_Strip.Text = "menuStrip";
            menu_Strip.Items.Add(menuItem);
            menu_Strip.Items.Add(menuItem1);

            return menu_Strip;
        }
        
        private void IsMDI_Form_Click3(object sender, System.EventArgs e)
        {
            string my_Message = "Здесь должна быть форма KPI";
            MessageBox.Show(my_Message);
        }

        private void IsMDI_Form_Click2(object sender, System.EventArgs e)
        {
            string my_Message = "Вы пытаетесь сохранить файл";
            MessageBox.Show(my_Message);
        }

        private void IsMDI_Form_Click1(object sender, System.EventArgs e)
        {
            string my_Message = "Вы пытаетесь открыть файл";
            MessageBox.Show(my_Message);
        }

        private void IsMDI_Form_Click(object sender, System.EventArgs e)
        {
            string my_Message = "Вы пытаетесь создать файл";
            MessageBox.Show(my_Message);
        }

        private void IsMDI_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form Main_Form = new Main_Form();
            Main_Form.Show();
        }
    }
}
