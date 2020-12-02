using System.Windows.Forms;
using System.Drawing;


namespace SuperJet_2._1.Toolbox
{
    class My_Label: Label
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int MyWidgth { get; set; }
        public int MyHeight { get; set; }

        public Label Create_MyLabel()
        {
            Size = new Size(MyWidgth, MyHeight);
            Location = new Point(X, Y);
            return this;
        }
    }
}
