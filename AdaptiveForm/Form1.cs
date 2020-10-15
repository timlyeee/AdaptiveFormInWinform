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
            if((Width/Height>1.8 && Height * Width > FormArea)||(Width / Height < 1.8 && Height * Width < FormArea))
            {
                //The Width changed
                Height = (int)(Width / 1.8);
                
            }
            else 
            {
                //The Height gets smaller
                Width = (int)(Height * 1.8);
               
            }

            FormArea = Height * Width;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //在此处生成并且根据屏幕分辨率设置大小
            Height = (int)(Screen.PrimaryScreen.Bounds.Height * 0.95);
            Width = (int)(Height * 1.8);
            FormArea = Height * Width;





        }
        
    }
}
