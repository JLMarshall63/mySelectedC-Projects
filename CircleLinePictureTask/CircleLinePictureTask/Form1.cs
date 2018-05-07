using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace CircleLinePictureTask
    {
    public partial class Form1 : Form
        {
        Random rand = new Random();
        Graphics drawArea;
        public Form1()
            {
            InitializeComponent();
            drawArea = pictureBoxCircles.CreateGraphics();
            }

        private void bttnStartLineCircle_Click_1(object sender, EventArgs e)
            {
            
            Graphics graph = panel1.CreateGraphics();
            Pen myPen = new Pen(Brushes.Blue, 1);
            

            int V1 = int.Parse(textBoxV1.Text);
            int V2 = int.Parse(textBoxV2.Text);

            float x = 0f;
            float y = 0f;
            float xSpace = (panel1.Width / V1) - myPen.Width;
            float ySpace = (panel1.Width / V1) - myPen.Width;
            Font myFont = new Font("Times New Roman", (panel1.Width <= panel1.Height) ? xSpace / 3: ySpace / 3);

            Task t1 = Task.Factory.StartNew(() =>
            {

                for (int counter = 0; counter <= V1; counter++)
                    {
                    SetText(String.Format("ID: {0}   {1}", Task.CurrentId.Value, counter), richTextBoxLines);

                    //vertical lines
                   
                    graph.DrawLine(myPen, x, y, x, ySpace * V1);
                    x += xSpace;
                    

                    //horizontal lines
                    x = 0f;
                    for ( int i = 0; i < V1 + 1; i++)
                        {
                        graph.DrawLine(myPen, x, y, xSpace * V1, y);
                        y += ySpace;
                        }
                    //text
                    x = 0f;
                    y = 0f;
                    int counter2 = 1;
                    for (int row = 0; row < V1; row++)
                        {
                        for (int column = 0; column < V1; column++)
                            {
                            graph.DrawString(Convert.ToString(counter2), myFont, Brushes.Red, x + myFont.Size, y + myFont.Size);
                            x += xSpace;
                            counter2++;
                            }
                        y += ySpace;
                        x = 0f;
                        }

                    System.Threading.Thread.Sleep(100);
                    }
            });

            Task t2 = Task.Factory.StartNew(() => DisplayCircles(V1, V2));
            }

        private void DisplayCircles(int V1, int V2)
            {
            drawArea.Clear(Color.AntiqueWhite);
            int xposition = rand.Next(-1000, 1001);
            for (int i = 0; i <= V2; i++)
                {

                SetText(String.Format("ID: {0}   {1}", Task.CurrentId.Value, i), richTextBoxCircles);

                SolidBrush blueBrush = new SolidBrush(Color.Blue);
                drawArea.FillEllipse(blueBrush, 10, 50, 200, xposition);

                System.Threading.Thread.Sleep(20);
                }
            }
        private void SetText(string text, RichTextBox rtb)
            {
            if (rtb.InvokeRequired)
                {
                Action<string, RichTextBox> action = SetText;
                rtb.Invoke(action, text, rtb);
                }
            else
                {
                rtb.AppendText(text + "\n");
                rtb.ScrollToCaret();
                }
            }
        }
    }

