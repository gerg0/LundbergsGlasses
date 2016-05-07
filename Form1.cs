using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing.Imaging;

namespace LunbergsGlasses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Image original_image;
        private Image current_image;
        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] dropped_files = (string[])e.Data.GetData(DataFormats.FileDrop);
            
            foreach(string file in dropped_files){
                pictureBox1.Image = Image.FromFile(file);
                current_image = Image.FromFile(file);
                original_image = Image.FromFile(file);
            }

            enableControls();
            
        }

        private void enableControls() {
            rScrollBar.Enabled = true;
            gScrollBar.Enabled = true;
            bScrollBar.Enabled = true;

            rBox.Enabled = true;
            gBox.Enabled = true;
            bBox.Enabled = true;
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true) {
                e.Effect = DragDropEffects.All;
            }
        }

        private Point startingPoint = Point.Empty;
        private Point movingPoint = Point.Empty;
        private bool panning = false;
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            panning = true;
            startingPoint = new Point(e.Location.X - movingPoint.X,
                                      e.Location.Y - movingPoint.Y);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            panning = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (panning){
                movingPoint = new Point(e.Location.X - startingPoint.X,
                                        e.Location.Y - startingPoint.Y);
                pictureBox1.Invalidate();
            }
        }

        //public event MouseEventHandler MouseWheel;
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (current_image != null){
                
                e.Graphics.Clear(Color.Black);
                e.Graphics.DrawImage(current_image, movingPoint);

            }
        }

        private int red_percent = 100;
        private int green_percent = 100;
        private int blue_percent = 100;
        private void ScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            red_percent = rScrollBar.Maximum - rScrollBar.Value - 9;
            r_label.Text = red_percent.ToString();
            
            green_percent = gScrollBar.Maximum - gScrollBar.Value - 9;
            g_label.Text = green_percent.ToString();

            blue_percent = bScrollBar.Maximum - bScrollBar.Value - 9;
            b_label.Text = blue_percent.ToString();

            current_image = ToColorTone(original_image);
            pictureBox1.Invalidate();
        }


        private Bitmap ToColorTone(Image image)
        {
            //creating a new bitmap image with selected color.

            float r = r_on * red_percent / 100f;
            float g = g_on * green_percent / 100f;
            float b = b_on * blue_percent / 100f;

            // Color Matrix
            ColorMatrix cm = new ColorMatrix(new float[][]
            {
                new float[] {r, 0, 0, 0, 0},
                new float[] {0, g, 0, 0, 0},
                new float[] {0, 0, b, 0, 0},
                new float[] {0, 0, 0, 1, 0},
                new float[] {0, 0, 0, 0, 1}
            });
            ImageAttributes ImAttribute = new ImageAttributes();
            ImAttribute.SetColorMatrix(cm);

            //Color Matrix on new bitmap image
            Point[] points =
            {
                new Point(0, 0),
                new Point(image.Width - 1, 0),
                new Point(0, image.Height - 1),
            };
            Rectangle rect = new Rectangle(0, 0, image.Width, image.Height);

            Bitmap myBitmap = new Bitmap(image.Width, image.Height);
            using (Graphics graphics = Graphics.FromImage(myBitmap))
            {
                graphics.DrawImage(image, points, rect, GraphicsUnit.Pixel, ImAttribute);
            }
            return myBitmap;
        }

        private int r_on = 1;
        private int g_on = 1;
        private int b_on = 1;
        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (rBox.Checked)
            {
                r_on = 1;
            }
            else
            {
                r_on = 0;
            }

            if (gBox.Checked)
            {
                g_on = 1;
            }
            else
            {
                g_on = 0;
            }

            if (bBox.Checked)
            {
                b_on = 1;
            }
            else
            {
                b_on = 0;
            }

            current_image = ToColorTone(original_image);
            pictureBox1.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject() != null)
            {
                IDataObject data = Clipboard.GetDataObject();

                if (data.GetDataPresent(DataFormats.Bitmap))
                {
                    current_image = (Image)data.GetData(DataFormats.Bitmap, true);
                    original_image = (Image)data.GetData(DataFormats.Bitmap, true);
                    pictureBox1.Invalidate();
                    enableControls();
                }
                else
                {
                    MessageBox.Show("No imagine in Clipboard !!");
                }
            }
            else
            {
                MessageBox.Show("Clipboard Empty !!");
            } 

        }


    }
}
