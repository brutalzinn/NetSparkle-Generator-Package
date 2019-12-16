using EncryptStringSample;
using HWIDgbr;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Update.Maker.Source_files;

namespace Update.Maker.Forms
{
    public partial class serialActivation : Form
    {
      

        license license = new license();
        public serialActivation()
        {
            InitializeComponent();
            Globals.serialActivation = this;
        }
     
      
     
      
    
        private void button1_Click(object sender, EventArgs e)
        {


            license.cad_license(textBox1.Text,Globals.ByForm.serialActivation.ToString());
            
            //check = true;
            //button1.Enabled = false;


            //real_url = "http://" + Globals.url + "/serial/serialcheck.php?serial=" + textBox1.Text+ "&hwidin=" + hwid + "&submit=Submit";

            //string response = SendRequest(real_url);
            //tratamento_response(response);
            //if (response != null)
            //{
            //   // MessageBox.Show(response, "Hey there!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}




        }
 




      
        
       
     
    }
}

