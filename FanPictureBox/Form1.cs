using FanPictureBox.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FanPictureBox
{
    public partial class Form1 : Form
    {


        public bool IsMaximize
        {
            get
            {
                return Settings.Default.IsMaximize;
            }
            set
            {
                Settings.Default.IsMaximize = value;

            }

        }
    
        public string PathPicture
        {
            get
            {
                return Settings.Default.PathPicture;
            }
            set
            {
                Settings.Default.PathPicture = value;
            }

        }







        public Form1()//konstruktor
        {
            InitializeComponent();
            if (IsMaximize)
            {
                WindowState = FormWindowState.Maximized;
            }


            if (PathPicture !="")
            {
                PathPicture = Settings.Default.PathPicture;

            }






        }


        private void btnDelPicture_Click(object sender, EventArgs e)
        {
          pictBox1.Image = null;
        }

        private void btnAddPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog pict = new OpenFileDialog();
                if(pict.ShowDialog()==DialogResult.OK)
            {
                Bitmap bit = new Bitmap(pict.FileName);
                pictBox1.Image = bit;
                pictBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                IsMaximize = true;
            else
                IsMaximize = false;

            Settings.Default.Save();

            if (pictBox1.Image !=null)
            {
                PathPicture = pictBox1.Image.ToString();
            }
            else
            {

                Bitmap bit = null;
                pictBox1.Image = bit;// PathPicture;
            }



        }
    }

}

