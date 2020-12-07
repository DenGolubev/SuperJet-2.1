using System.Windows.Forms;
using SuperJet_2._1.Forms;

namespace SuperJet_2._1.Forms
{
    partial class isMDI_Form: BaseForm
    {
        MenuStrip menu_Strip = new MenuStrip();
        
        private void InitializeComponent()
        {
            menu_Strip = myMenuStrip();
            WindowState = FormWindowState.Maximized;
            IsMdiContainer = true;
            FormClosing += IsMDI_Form_FormClosing;
            Controls.Add(menu_Strip);
        }

        private MenuStrip myMenuStrip()
        {
            // 
            // ToolStripMenuItem
            // 
            ToolStripMenuItem menuItem, menuItem1, menuItem2, menuItem3;
            menuItem = new ToolStripMenuItem("Файл");
            menuItem.DropDownItems.Add("Создать").Click += IsMDI_Form_Click; ;
            menuItem.DropDownItems.Add("Открыть").Click += IsMDI_Form_Click1; ;
            menuItem.DropDownItems.Add("Сохранить").Click += IsMDI_Form_Click2;
            menuItem1 = new ToolStripMenuItem("Отчеты");
            menuItem1.DropDownItems.Add("Создать").Click += IsMDI_Form_Click3; ;
            menuItem1.DropDownItems.Add("Отправить");
            menuItem2 = new ToolStripMenuItem("Сотрудники");
            menuItem2.DropDownItems.Add("Принять на работу").Click += IsMDI_Form_Click4; ;
            menuItem2.DropDownItems.Add("Уволить с работы").Click += IsMDI_Form_Click5; ;
            menuItem3 = new ToolStripMenuItem("Охрана труда");
            menuItem3.DropDownItems.Add("Внести данные").Click += IsMDI_Form_Click6; ;
            menuItem3.DropDownItems.Add("Карточка сотрудника");


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
            menu_Strip.Items.Add(menuItem2);
            menu_Strip.Items.Add(menuItem3);

            return menu_Strip;
        }

        
    }
}
