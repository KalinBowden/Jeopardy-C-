using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jepordy
{
    public partial class Splash : Form
    {
        // Class level varaibles.
        private int count = 0;
        private int index = 0;
        private char[] myChar;

        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            //
            myChar = lblLoading.Text.ToCharArray();
            DisplaySplash();
        }

        public void DisplaySplash()
        {
            timer1.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count < 101)
            {
                progressBar1.Value = count;
            }
            

            //if (index == 0)
            //{
            //    myChar[index] = (char)((int)myChar[index] + 28);
            //    index++;
            //}
            //else if (index < 7)
            //{
            //    myChar[index - 1] = (char)((int)myChar[index] - 28);
            //    myChar[index] = (char)((int)myChar[index] + 28);
            //    index++;
            //}
            //else
            //{
            //    myChar[index - 1] = (char)((int)myChar[index] - 28);
            //    index = 0;
            //}
            count++;

            lblLoading.Text = new String(myChar);

            if (count == 100)
            {
                this.Close();
            }
        }
    }
}
