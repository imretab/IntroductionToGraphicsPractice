using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RasterShapesDraw
{
    public partial class Form1 : Form
    {
        Color newColor;
        public Form1()
        {
            InitializeComponent();
        }
        void Rectangle(int x0, int y0, int dx, int dy, Color color)
        {
            Bitmap bm = (Bitmap)pictureBox.Image;
            for (int x = x0; x < Math.Min(x0 + dx, pictureBox.Width); ++x)
            {
                for (int y = y0; y < Math.Min(y0 + dy, pictureBox.Height); ++y)
                {
                    bm.SetPixel(x, y, color);
                }
            }
        }
        void Checker(int dx, int dy)
        {
            int maxX = pictureBox.Width; int maxY = pictureBox.Height;
            Bitmap bm = (Bitmap)pictureBox.Image;//bm a picBxKep Image-re mutat
            bool isSelectedColor = true;
            Color color = newColor;
            //első sor:
            for (int x0 = 0; x0 < maxX; x0 += dx)
            {
                if (isSelectedColor) color = newColor; else color = Color.White;
                Rectangle(x0, 0, dx, dy, color);
                isSelectedColor = !isSelectedColor;
            }
            for (int y0 = dy; y0 < maxY; y0 += dy)
            {
                for (int x0 = 0; x0 < maxX; x0 += dx)
                {
                    isSelectedColor = bm.GetPixel(x0, y0 - dy) == Color.FromArgb(newColor.ToArgb());
                    isSelectedColor = !isSelectedColor;
                    if (isSelectedColor) color = newColor; else color = Color.White;
                    Rectangle(x0, y0, dx, dy, color);
                }
            }
            pictureBox.Refresh();
        }
        void Noisy()
        {
            Bitmap bm = (Bitmap)pictureBox.Image;
            Random r = new Random();
            for (int y = 0; y < pictureBox.Height; y++)
            {
                for (int x = 0; x < pictureBox.Width; x++)
                {
                    bm.SetPixel(x, y, r.Next() % 2 == 0 ? Color.White : newColor);
                }
            }
            pictureBox.Refresh();
        }
        private void colorPicker_Click(object sender, EventArgs e)
        {
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                newColor = colorDialog.Color;
                chosenColor.BackColor = newColor;
            }
        }

        private void chosenColor_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Current color value: {colorDialog.Color}", "INFO",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btn_Draw_Click(object sender, EventArgs e)
        {
            switch (listBoxOptions.SelectedIndex)
            {
                case 0:
                    Rectangle(0, 0, pictureBox.Width, pictureBox.Height, newColor);
                    pictureBox.Refresh();
                    break;
                case 1:
                    try {
                        string values = checkPatternBox.Text;
                        string[] splitted = values.Split(',');
                        int x, y;
                        if (!int.TryParse(splitted[0],out x) || !int.TryParse(splitted[1],out y))
                        {
                            throw new FormatException();
                        }
                        x = int.Parse(splitted[0]);
                        y = int.Parse(splitted[1]);
                        if(x <= 0 || y <= 0)
                        {
                            throw new LessThanZeroException();
                        }
                        Checker(x, y);
                    }
                    catch (FormatException fe)
                    {
                        MessageBox.Show(fe.Message,"ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    catch(LessThanZeroException le)
                    {
                        MessageBox.Show(le.Message, "ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    break;
                case 2:
                    Noisy();
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox.Image = new Bitmap(pictureBox.Width, pictureBox.Height);
        }

        private void listBoxOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxOptions.SelectedIndex == 1) {
                checkPatternLabel.Visible = true;
                checkPatternBox.Visible = true;
            }
            else
            {
                checkPatternBox.Visible = false;
                checkPatternLabel.Visible = false;
            }
        }

        private void pictureBox_SizeChanged(object sender, EventArgs e)
        {
            pictureBox.Image = new Bitmap(pictureBox.Width, pictureBox.Height);
            btn_Draw_Click(sender,e);
        }
    }
}
