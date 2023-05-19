using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Digital_Clock
{
    
    public partial class Form1 : Form
    {

        System.Windows.Forms.Timer t = null;
        

        public Form1()
        {
            InitializeComponent();
            StartTimer();
            date();
        }

        private void StartTimer()
        {
            t = new System.Windows.Forms.Timer();
            t.Interval = 1000;
            t.Tick += new EventHandler(t_Tick);
            t.Enabled = true;
        }    

        public void date()
        {
            DateOfNow.Text = DateTime.Today.ToString("dd dddd yyyy");
        }
        
        private void t_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString("HH:mm:ss");
        }
       
      
    }
}
