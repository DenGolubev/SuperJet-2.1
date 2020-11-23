using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperJet_2._1;

namespace SuperJet_2._1.Forms
{
    class MDI_Form: Form
    {
        public MDI_Form()
        {
            this.FormClosing += MDI_Form_FormClosing;
            InitializeComponent();
        }

        private void MDI_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main_Form main_Form = new Main_Form();
            main_Form.Show();
            this.Hide();
        }

        private void InitializeComponent()
        {
            my_Menu_Strip menu_Strip = new my_Menu_Strip();
            // 
            // ToolStripMenuItem
            // 
            ToolStripMenuItem menuItem, menuItem1;
            menuItem = menu_Strip.My_Menu("File");
            menuItem.DropDownItems.Add("Создать").Click += MDI_Form_Click;
            menuItem.DropDownItems.Add("Открыть").Click += MDI_Form_Click1;
            menuItem.DropDownItems.Add("Сохранить").Click += MDI_Form_Click2;
            menuItem1 = menu_Strip.My_Menu("Report");
            menuItem1.DropDownItems.Add("Создать").Click += MDI_Form_Click3; ;
            menuItem1.DropDownItems.Add("Отправить");
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            menu_Strip.Location = new System.Drawing.Point(0, 0);
            menu_Strip.Name = "menuStrip";
            menu_Strip.Size = new System.Drawing.Size(800, 24);
            menu_Strip.TabIndex = 0;
            menu_Strip.Text = "menuStrip";
            menu_Strip.Items.Add(menuItem);
            menu_Strip.Items.Add(menuItem1);
            // 
            // new_Form
            // 
            this.IsMdiContainer = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.WindowState = FormWindowState.Maximized;
            //this.ClientSize = new System.Drawing.Size(1024, 800);
            this.Controls.Add(menu_Strip);
            this.MainMenuStrip = menu_Strip;
            this.Name = "MDI_Form";
            this.Text = "Родительская форма";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void MDI_Form_Click3(object sender, EventArgs e)
        {
            Form KPI = new KPI();
            KPI.MdiParent = this;
            KPI.Show();
        }

        private void MDI_Form_Click2(object sender, EventArgs e)
        {
            string my_Message = "Вы пытаетесь сохранить файл";
            MessageBox.Show(my_Message);
        }

        private void MDI_Form_Click1(object sender, EventArgs e)
        {
            string my_Message = "Вы пытаетесь открыть файл";
            MessageBox.Show(my_Message);
        }

        private void MDI_Form_Click(object sender, EventArgs e)
        {
            string my_Message = "Вы пытаетесь создать файл";
            MessageBox.Show(my_Message);
        }
    }
}
