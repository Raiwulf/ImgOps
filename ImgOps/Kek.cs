using System;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Threading;
using System.Drawing;
using System.Threading.Tasks;
using System.Timers;
using System.Diagnostics;
using System.IO;
using ImgOps;

namespace ImgFinder
{
    public partial class Kek : Form
    {
        public Kek()
        {
            InitializeComponent();
        }

        private void Kek_Load(object sender, EventArgs e)
        {
        }

        private void impBtn_Click(object sender, EventArgs e)
        {
            Image a = Import.importFunc();
            impPic.Image = a;
            a.Save("imported.png", ImageFormat.Png);
            SScap wC = new SScap("");
            wC.ConG("imported.png", "imported-gs.png");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            winH window = new winH(this.wName.Text);
            IntPtr pointer = window.wHandle();
            SScap wC = new SScap("title");
            wC.winYakala(pointer, "ss.png", ImageFormat.Png);
            wC.ConG("ss.png");
            img2bit i2b = new img2bit();
            Color[][] x, y;
            int xWidth, xHeight, yWidth, yHeight;
            (x,xWidth,xHeight) = i2b.i2b("Grayscale.png");
            Log.AppendText("Scanning...\n");
            (y, yWidth, yHeight) = i2b.i2b("imported-gs.png");
            i2b.Scan(x,xWidth,xHeight,y,yWidth,yHeight);
            Log.AppendText("Drawing...\n");
        }

        private void scanCB_CheckedChanged(object sender, EventArgs e)
        {
            if (scanCB.Checked)
            {
                timer1.Interval = int.Parse(scanDelay.Text);
                timer1.Start();
            }
            else
            {
                timer1.Stop();
                Log.AppendText("Stopped");
            }
        }
    }
}
