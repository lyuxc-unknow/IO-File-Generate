using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form2 : Form
    {
        string getFileDirectory = "";
        public Form2()
        {
            InitializeComponent();
            getFileDirectory = Directory.GetCurrentDirectory();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void setup_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader i = new StreamReader(getFileDirectory + "\\" + fileName.Text + ".in");
                input.Text = i.ReadToEnd();
                StreamReader o = new StreamReader(getFileDirectory + "\\" + fileName.Text + ".out");
                output.Text = o.ReadToEnd();
                try
                {
                    fileName.Text = int.Parse(fileName.Text) + 1 + "";
                }
                catch 
                {

                }
                i.Close();
                o.Close();
            }
            catch
            {

            }
        }
    }
}
