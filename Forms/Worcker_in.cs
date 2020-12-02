using System;
using System.Drawing;
using System.Windows.Forms;

namespace SuperJet_2._1.Forms
{
    class Worcker_in: Form
    {
        public Worcker_in()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            Size = new Size(1024, 800);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            StartPosition = FormStartPosition.CenterScreen;
            SuspendLayout();
        }
    }
}
