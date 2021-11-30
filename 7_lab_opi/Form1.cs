using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_lab_opi
{
    public partial class Form1 : Form
    {
        private Pen mainPen = new Pen(Color.Black, 5);
        private Point PreviousPoint;
        private bool isHold;
        private bool isFirst;
        private Active active;
        private Point point;

        enum Active
        {
            Pencil,
            Line,
            Rect,
            Circle,
            Text
        }


        public Form1()
        {
            InitializeComponent();
            mainPen.StartCap = LineCap.Round;
            mainPen.EndCap = LineCap.Round;
            active = Active.Pencil;
            isFirst = true;
        }

        //void Drawellipse(Point point)
        //{
        //    // якщо один раз вже клацнули
        //    if (Firstclick == true)
        //    {
        //        // створюємо об’єкт Pen
        //        Pen blасkреn = new Pen(Color.Black, 3);
        //        // створюємо об’єкт Graphics
        //        Graphics g = this.CreateGraphics();
        //        // малюємо еліпс
        //        g.DrawEllipse(Pens.Black, Previouspoint.X, Previouspoint.Y, point.X - Previouspoint.X,
        //            point.Y - Previouspoint.Y);
        //        Firstclick = false;
        //    }
        //    else
        //    {
        //        Firstclick = true;
        //    }
        //}

        //void Drawtext(Point point)
        //{
        //    // створюємо об’єкт Graphics
        //    Graphics g = this.CreateGraphics();
        //    // створюємо об’єкт Font
        //    Font titlefont = new Font("Lucida Sans Unicode", 15);
        //    // малюємо текст  червоним кольором
        //    g.DrawString("Програмування на С#", titlefont, new SolidBrush(Color.Red), point.X, point.Y);
        //}

        private void color_btn_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            mainPen.Color = colorDialog1.Color;
            color_btn.ForeColor = colorDialog1.Color;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isHold = true;
            PreviousPoint = new Point(e.X, e.Y);

            Graphics graphics = pictureBox1.CreateGraphics();
            if (active == Active.Line)
            {
                if (isFirst)
                {
                    firstPoint = point;
                    graphics.DrawLine(mainPen, point.X + 0.2f, point.Y + 0.2f, point.X + 0.1f, point.Y + 0.1f);
                    isFirst = false;
                }
                else
                {
                    graphics.DrawLine(mainPen, firstPoint, point);
                    isFirst = true;
                }
            }
            else if(active == Active.Circle)
            {
                if (isFirst)
                {
                    firstPoint = point;
                    isFirst = false;
                }
                else
                {
                    graphics.DrawEllipse(mainPen, firstPoint.X, firstPoint.Y, point.X - firstPoint.X, point.Y - firstPoint.Y);  
                    isFirst = true;
                }
               
            }
            else if (active == Active.Rect)
            {
                if (isFirst)
                {
                    firstPoint = point;
                    graphics.DrawLine(mainPen, point.X + 0.2f, point.Y + 0.2f, point.X + 0.1f, point.Y + 0.1f);
                    isFirst = false;
                }
                else
                {  
                    if (firstPoint.X > point.X && firstPoint.Y > point.Y)
                    {
                        graphics. DrawRectangle(mainPen, point.X, point.Y,
                            Math.Abs(point.X - firstPoint.X), Math.Abs(point.Y - firstPoint.Y));
                    }
                    else if (firstPoint.Y > point.Y && firstPoint.X < point.X)
                    {
                        graphics.DrawRectangle(mainPen, firstPoint.X, point.Y,
                            Math.Abs(point.X - firstPoint.X), Math.Abs(point.Y - firstPoint.Y));
                    }
                    else if (firstPoint.Y < point.Y && firstPoint.X < point.X)
                    {
                        graphics.DrawRectangle(mainPen, firstPoint.X, firstPoint.Y,
                            Math.Abs(point.X - firstPoint.X), Math.Abs(point.Y - firstPoint.Y));
                    }
                    else
                    {
                        graphics.DrawRectangle(mainPen, point.X, firstPoint.Y,
                            Math.Abs(point.X - firstPoint.X), Math.Abs(point.Y - firstPoint.Y));

                    }
                    isFirst = true;
                }

            }
            else if(active == Active.Text)
            {
                Font font = new Font("Century Gothic", 15);
                Brush brash = new SolidBrush(colorDialog1.Color);
                graphics.DrawString(textBox1.Text, font, brash, point.X, point.Y);
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isHold = false;
        }

        private Point firstPoint;
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            point = new Point(e.X, e.Y);
            if (isHold && active == Active.Pencil)
            {
                Graphics graphics = pictureBox1.CreateGraphics();
                graphics.DrawLine(mainPen, PreviousPoint, point);
                PreviousPoint = point;
            }
        }

        private void pencil_btn_Click(object sender, EventArgs e)
        {
            active = Active.Pencil;
        }

        private void line_btn_Click(object sender, EventArgs e)
        {
            active = Active.Line;
        }

        private void text_btn_Click(object sender, EventArgs e)
        {
            active = Active.Text;
        }

        private void circle_btn_Click(object sender, EventArgs e)
        {
            active = Active.Circle;
        }

        private void rect_btn_Click(object sender, EventArgs e)
        {
            active = Active.Rect;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox1.CreateGraphics();
            graphics.Clear(Color.White);
        }
    }
}
