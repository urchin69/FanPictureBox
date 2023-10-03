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

        private string _currentPath;

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

            try
            {
                if (!string.IsNullOrWhiteSpace(PathPicture))
                {
                    pictBox1.Image=Image.FromFile(PathPicture);
                    _currentPath = PathPicture;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Processing failed: {ex.Message}");
            }
          }

        private void btnDelPicture_Click(object sender, EventArgs e)
        {
            pictBox1.Image = null;
            _currentPath = null;
            //PathPicture = null;
            //Settings.Default.Save();

        }

        private void btnAddPicture_Click(object sender, EventArgs e)
        {
            //OpenFileDialog pict = new OpenFileDialog();
            //    if(pict.ShowDialog()==DialogResult.OK)
            //{
            //    Bitmap bit = new Bitmap(pict.FileName);
            //    pictBox1.Image = bit;
            //    pictBox1.SizeMode = PictureBoxSizeMode.Zoom;
            //}
            //inaczej

            OpenFileDialog pict = new OpenFileDialog();

            if (pict.ShowDialog() == DialogResult.OK)
            {
                pictBox1.Image = Image.FromFile(pict.FileName);
                pictBox1.SizeMode = PictureBoxSizeMode.Zoom;
                _currentPath = pict.FileName;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                IsMaximize = true;
            else
                IsMaximize = false;


            if (!String.IsNullOrWhiteSpace(_currentPath))
            {
                PathPicture = _currentPath;
            }
            else
            {
                PathPicture = null;
            }

            Settings.Default.Save();

        }
    }

}

