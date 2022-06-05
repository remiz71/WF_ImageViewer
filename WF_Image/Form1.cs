using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Timer = System.Windows.Forms.Timer;

namespace WF_Image
{
    public partial class Form1 : Form
    {
        Timer timer = new Timer();
        List<Image> _imageList = new List<Image>();
        int counter =0;
        bool isPlay = false;
        public Form1()
        {
            InitializeComponent();
            timer.Interval = 500;
            timer.Tick += _next_Click;
        }

        private void _openf_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                timer.Stop();
                if(_imageList.Count!=0)
                {
                    foreach (var item in _imageList)
                    {
                        item.Dispose();
                    }
                    _imageList.Clear();
                }
                DirectoryInfo di = new DirectoryInfo(folderBrowserDialog1.SelectedPath);
                IEnumerable<FileInfo> alf = di.EnumerateFiles();
                foreach(var items in alf)
                {
                    string ex = Path.GetExtension(items.FullName);
                    if(ex==".bmp" || ex == ".jpg" || ex == ".png")
                    {
                    _imageList.Add(new Bitmap(items.FullName));

                    }
                }
                counter = 0;
                pictureBox1.Image = _imageList[counter];
                
                label1.Text = $"{counter + 1} / {_imageList.Count}"; ;
            }
        }

        private void _next_Click(object sender, EventArgs e)
        {
            NextPicture();
            
        }

        private void NextPicture()
        {
            if (_imageList.Count == 0)
            {
                return;
            }
            counter++;
            if (counter >= _imageList.Count)
                counter = 0;
            pictureBox1.Image = _imageList[counter];
            label1.Text = $"{counter + 1} / {_imageList.Count}";
        }

        private void _prev_Click(object sender, EventArgs e)
        {
            if (_imageList.Count == 0)
            {
                return;
            }
            counter--;
            if (counter < 0)
                counter = _imageList.Count-1;
            pictureBox1.Image = _imageList[counter];
            label1.Text = $"{counter + 1} / {_imageList.Count}";

        }

        private void _start_Click(object sender, EventArgs e)
        {
            if (_imageList.Count!=0)
            {
            timer.Start();

            }
            else
            {
                MessageBox.Show("Не выбрана папка");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }
    }
}
