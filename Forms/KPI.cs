using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using SuperJet_2._1.Toolbox;

namespace SuperJet_2._1.Forms
{
    class KPI: Form
    {
        
        public KPI()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            //
            // Label0
            //
            My_Label label0 = new My_Label("Отчет по основным показателям KPI");
            label0.Location = new Point(270, 20);
            label0.Height = 30;
            label0.Width = 500;
            label0.Font = new Font("Arial", 20.00F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.Controls.Add(label0);

            //
            // Label1 and TextBox1
            //
            My_Label label1 = new My_Label("Конвертация по нарядам :");
            label1.Location = new Point(10, 100);
            label1.Width = 280;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.Controls.Add(label1);

            My_TextBox textBox1 = new My_TextBox("");
            textBox1.Location = new Point(300, 100);
            textBox1.Enabled = false;
            textBox1.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.Controls.Add(textBox1);



            this.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.Size = new Size(1024, 800);
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.SuspendLayout();
        }


    }
    
}
