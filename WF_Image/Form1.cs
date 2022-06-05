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

namespace WF_Image
{
    public partial class Form1 : Form
    {
        List<Image> _imageList = new List<Image>();
        int counter =0;
        bool isPlay = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void _openf_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string[] _filepaths = Directory.GetFiles(folderBrowserDialog1.SelectedPath, "*.jpg");
                foreach(var items in _filepaths)
                {
                    _imageList.Add(new Bitmap(items));
                }
                pictureBox1.Image = _imageList[counter];
                
                label1.Text = label1.Text = $"{counter + 1} / {_imageList.Count}"; ;
            }
        }

        private void _next_Click(object sender, EventArgs e)
        {
            if (counter < _imageList.Count - 1) counter++;
            else counter = 0;
            label1.Text = $"{counter + 1} / {_imageList.Count}";
            pictureBox1.Image = _imageList[counter];
            
        }

        private void _prev_Click(object sender, EventArgs e)
        {
            if (counter > 0) counter--;
            else counter = _imageList.Count - 1;
            label1.Text = $"{counter + 1} / {_imageList.Count}";
            pictureBox1.Image = _imageList[counter];
            
        }

        private void _start_Click(object sender, EventArgs e)
        {

            do
            {
                pictureBox1.Image = _imageList[counter];
                counter++;
                if (counter > _imageList.Count - 1)
                    counter = 0;
                Thread.Sleep(200);
            } while (isPlay);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            isPlay = false;
        }
    }
}
