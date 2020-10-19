using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdaptiveForm
{
    public partial class Form1 : Form
    {
        int FormArea;
        public Form1()
        {
           
            //TODO: 布局随缩放同等比例变化，而不是固定padding和margin
            //TODO: 拉伸width时height也随之变化
            InitializeComponent();
        }

        private void Form1_SizeChanged(object sender,EventArgs e)
        {
            float Ratio;
            if((Width/Height>1.8 && Height * Width > FormArea)||(Width / Height < 1.8 && Height * Width < FormArea))
            {
                //The Width changed
                int O_height = Height;
                Height = (int)(Width / 1.8);
                Ratio =(float) Height /(float) O_height;
            }
            else 
            {
                //The Height gets smaller
                int O_Width = Width;
                Width = (int)(Height * 1.8);
                Ratio =(float) Width / (float)O_Width;
            }
            PictureBoxResize(pictureBox1, Ratio);
            FormArea = Height * Width;
            Console.WriteLine("tableLayoutInfo" +tableLayoutPanel1.Size+
                "Padding"+tableLayoutPanel1.Padding+
                "margin"+tableLayoutPanel1.Margin);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //在此处生成并且根据屏幕分辨率设置大小
            Height = (int)(Screen.PrimaryScreen.Bounds.Height * 0.95);
            Width = (int)(Height * 1.8);
            FormArea = Height * Width;
            
        }
        private void PictureBoxResize(PictureBox pb,float ratio)
        {
            pb.Location = new Point((int)(ratio * pb.Location.X), (int)(ratio * pb.Location.Y));
            pb.Height = (int)(ratio*pb.Height);
            pb.Width = (int)(ratio * pb.Width);

        }
    }
}
