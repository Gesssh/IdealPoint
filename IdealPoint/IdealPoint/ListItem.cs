using System.Drawing;
using System.Windows.Forms;

namespace IdealPoint
{
    class ListItem : Panel
    {
        private int num;
        private string name;

        public Label NameLabel;
        public TextBox DescriptionTB;

        public ListItem(int Num, string Name)
        {
            num     = Num;
            name    = Name;

            Width   = 380;
            Height  = 25;

            NameLabel     = new();
            DescriptionTB = new();

            NameLabel.Width     = 25;   NameLabel.Height     = 25;
            DescriptionTB.Width = 350;  DescriptionTB.Height = 25;


            Location               = new Point(0, Location.Y + 30 * Num);
            NameLabel.Location     = new Point(0, 3);
            DescriptionTB.Location = new Point( 30, DescriptionTB.Location.Y);

            NameLabel.Text = name + num;

            Controls.Add(NameLabel);
            Controls.Add(DescriptionTB);
        }
    }
}
