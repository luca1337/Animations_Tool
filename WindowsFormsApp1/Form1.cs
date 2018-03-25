using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenTK;
using Aiv.Fast2D;

namespace WindowsFormsApp1
{
    public partial class AnimationsTool : Form
    {
        private OpenFileDialog load;
        private PictureBox spriteSheet;
        private PictureBox animation;
        private string fileName;
        private Window window;
        public AnimationsTool()
        {
            load = new OpenFileDialog();
            spriteSheet = new PictureBox();
            animation = new PictureBox();

            InitializeComponent();
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            load.Title = " Select a sprite sheet";
            load.Multiselect = true;
            load.Filter = "PNG|*.png";
            //This method after all settings of file dialog
            DialogResult dr = load.ShowDialog();

            if (dr == DialogResult.OK)
            {
                fileName = load.FileName;

                //Set picture box
                spriteSheet.Image = Image.FromFile(fileName);
                spriteSheet.Size = PanelImage.Size;
                spriteSheet.SizeMode = PictureBoxSizeMode.Zoom;

                //Add component to panel
                this.PanelImage.Controls.Add(spriteSheet);
            }

        }


        private void AnimationPanel_Paint_1(object sender, PaintEventArgs e)
        {
            if (window == null)
                window = new Window(AnimationPanel.Width, AnimationPanel.Height, "Animation");

          //  SetDesktopLocation(10, 10);
            //int x = AnimationPanel.Location.X - DesktopLocation.X;
            //int y = AnimationPanel.Location.Y + DesktopLocation.Y;
            //Point position  = new Point(x,y);
            //window.Position = ExtensionMethod.PointToVector(position);

            window.SetDefaultOrthographicSize(1);
            Sprite sprite = new Sprite(1, 1);
            while (window.IsOpened)
            {

                if (window.GetKey(KeyCode.Esc))
                    window.Exit();

                //Window Pos
                int x = AnimationPanel.Location.X - DesktopLocation.X;
                int y = AnimationPanel.Location.Y + DesktopLocation.Y;
                Point position = new Point(1/x, y);
                window.Position = ExtensionMethod.PointToVector(position);



                sprite.DrawSolidColor(0f, 1f, 0f);
                window.Update();
            }
        }
    }
}
