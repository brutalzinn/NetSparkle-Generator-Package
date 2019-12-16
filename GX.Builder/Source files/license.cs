using EncryptStringSample;
using HWIDgbr;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Update.Maker.Forms;

namespace Update.Maker.Source_files
{

     class license
    {
        private enum codigo
        {
            erro,
            grave,
            aviso,
            importante,
            GERENCIADOR




        }
        bool check;
        string hwid;

        string real_url = "";
        string quemchamou = "";
        public static string GenerateCoupon(int length)
        {
            Random random = new Random();
            string characters = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            StringBuilder result = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                result.Append(characters[random.Next(characters.Length)]);
            }
            return result.ToString();
        }
        public  void  cad_license(string textbox , string by = "class")
        {

            if(by != Globals.ByForm.none.ToString())
            {
            quemchamou = by;



            }
           

            check = true;
            hwid = HWDI.GetMachineGuid();
            real_url = "http://" + Globals.url + "/serial/serialcheck.php?serial=" + textbox + "&hwidin=" + hwid + "&crypt=" + save_password(GenerateCoupon(30)) + "&submit=Submit";
            tratamento_response(SendRequest(real_url),textbox, by);

          



        }


        public string save_password(string password)
        {


           // cryptkey = GenerateCoupon(30);
          //  hwid = HWDI.GetMachineGuid();

         //   string encryptedstring = StringCipher.Encrypt(hwid, password);

            Properties.Settings.Default.KeyCrypt = password;
            Properties.Settings.Default.Save();
            return password;

        }

        public void Start(string by = "class")
        {
            check = false;
            hwid = HWDI.GetMachineGuid();
           



            //var ping = new System.Net.NetworkInformation.Ping();

            //var result = ping.Send(Globals.url);




            //if (result.Status != System.Net.NetworkInformation.IPStatus.Success)
            //    return;

            if (Properties.Settings.Default.Installed == true)
            {
                check = true;


                real_url = "http://" + Globals.url + "/serial/serialcheck.php?serial=" + Properties.Settings.Default.Serial + "&hwidin=" + hwid + "&crypt=" + Properties.Settings.Default.KeyCrypt + "&submit=Submit";

                Thread t = new Thread(() => NovaThread(by));
                t.Start();











                //  return Properties.Settings.Default.Serial;


            }
            //  verifyifiscorrect();

        }
        void NovaThread(string by)
        {



            TaskEx.Run(async () =>
            {
                while (check)
                {
                    // do the work in the loop
             
                    tratamento_response(SendRequest(real_url),Properties.Settings.Default.Serial,by);
                    log(Globals.code.aviso, "Licença verificada");
                    // don't run again for at least 200 milliseconds
                    Console.WriteLine("VERIFICANDO" + real_url);


                    //    form_principal.log(code.GERENCIADOR, "verificando license - ");

                    await TaskEx.Delay(200);
                }
            });


        }
        private void log_last()

        { 


            Globals.principal.license_text_show.Text = "Última verificação: " + DateTime.Now;


            }
        private void log(Globals.code resposta, string info)
        {
            log_last();
            Globals.principal.log_list.AppendText(DateTime.Now + "[" + resposta + "]:" + " " + info + Environment.NewLine);





        }
        public string SendRequest(string url)
        {
            try
            {

                using (WebClient client = new WebClient())
                {
                    return client.DownloadString(new Uri(url));
                }
            }
            catch (WebException ex)
            {
                MessageBox.Show("Error while receiving data from the server:\n" + ex.Message, "Something broke.. :(", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return null;
            }
        }

  
        public void tratamento_response(string response,string serial, string by)
        {



            if (check == true)
            {
                if (response.Contains("0"))
                {
                    check = false;
                    //timer1.Stop();
                    //button1.Enabled = true;
                    MessageBox.Show("HWID ERRADO, OU SUA LICENÇA NÃO É VÁLIDA.");

                }
                else if (response.Contains("1"))
                {
                    check = false;
                    ////timer1.Stop();
                    ////button1.Enabled = true;
                    Properties.Settings.Default.Serial = serial;
                    Properties.Settings.Default.Installed = true;
                    Properties.Settings.Default.Save();

                    RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\pathbuilder");
                    string encryptedstring = StringCipher.Encrypt(hwid, Properties.Settings.Default.KeyCrypt);

                    //storing the values  
                    key.SetValue("status", "1");
                    key.SetValue("hwid", hwid);
                    key.SetValue("key", encryptedstring);
                    key.Close();
                    Console.WriteLine(by);



                    if (by == Globals.ByForm.principal.ToString())
                    {
                        Console.WriteLine(Globals.ByForm.principal.ToString());

                        Console.WriteLine("CHAVE CADASTRADA.");
                        log(Globals.code.aviso, "Licença verificada com sucesso.");
                



                    }
                    else
                    {

                        MessageBox.Show("Licença válida");
                        Globals.serialActivation.Invoke(new Action(() => Globals.serialActivation.Hide()));




                        principal teste = new principal();
                        teste.ShowDialog();


                    }




                    //Globals.serialActivation.Invoke(new Action(() => Globals.serialActivation.Hide()));




                    //   principal teste = new principal();

                    //   teste.ShowDialog();
                    //   MessageBox.Show("Chave ativada com sucesso");





                    //  principal form = new principal();

                    //form.Show();

                    //this.Hide();
                    //this.FormClosed += new FormClosedEventHandler(Form2_FormClosed);






                }
                else if (response.Contains("2"))
                {
                    check = false;
                    //timer1.Stop();
                    //button1.Enabled = true;
                    MessageBox.Show("HWID field left empty");
                }
                else if (response.Contains("3"))
                {
                    check = false;




                    if (by == Globals.ByForm.principal.ToString())
                    {

                        Console.WriteLine(Globals.ByForm.principal.ToString());

                        Console.WriteLine("ESSA CHAVE NÃO É VÁLIDA.");

  Globals.principal.Invoke(new Action(() => Globals.principal.Hide()));




                    serialActivation teste = new serialActivation();

                    teste.ShowDialog();



                    }
                    else
                    {

                        MessageBox.Show("Licença inválida");
                    }

                  


                    //timer1.Stop();
                    //button1.Enabled = true;



                }
                //else if (response.Contains("4"))
                //{

                //    Globals.principal.Invoke(new Action(() => Globals.principal.Enabled = false)) ;

                //    MessageBox.Show("Crypt key ERROR 404","ERROR");

                //    Environment.Exit(0);


                //}


                else if (response.Contains("Object not found"))
                {
                    check = false;
                    //timer1.Stop();
                    //button1.Enabled = true;
                    MessageBox.Show("404: Page not found");
                }

            }
        }

        


    }
}
