using EncryptStringSample;
using HWIDgbr;
using Microsoft.Win32;
using System;
using System.Threading;
using System.Windows.Forms;
using Update.Maker.Forms;

namespace Update.Maker
{
    static class Program
    {

        [STAThread]
        static void Main()
        {
     
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);



            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\pathbuilder");

            //if it does exist, retrieve the stored values  












            if (key != null)
            {
                try
                {
                    string hwid = "";
                    string teste = "";

                  
                    string chave_reg = key.GetValue("key").ToString();
                    if (chave_reg != null)
                    {

                      
                        string decryptedstring = StringCipher.Decrypt(key.GetValue("key").ToString(), Properties.Settings.Default.KeyCrypt);
                        hwid = HWDI.GetMachineGuid();
                        Console.WriteLine(hwid);
                        Console.WriteLine(decryptedstring);




                        if (hwid == decryptedstring)
                        {

                            Application.Run(new MultiFormContext(new principal()));
                            Console.WriteLine("iniciando principal");
                        }
                        else
                        {
                         Application.Run(new MultiFormContext(new serialActivation()));

                            Console.WriteLine("iniciando license form");


                        }



                    }
                    else
                    {

                    Application.Run(new MultiFormContext(new serialActivation()));

                    }


                }
                catch
                {
                Application.Run(new MultiFormContext(new serialActivation()));


                }


                //descomentar todos os   Application.Run(new MultiFormContext(new serialActivation())); para compilar.

               // Application.Run(new MultiFormContext(new principal()));










            }

        }

        
        public class MultiFormContext : ApplicationContext
        {
            private int openForms;
            public MultiFormContext(params Form[] forms)
            {
                openForms = forms.Length;

                foreach (var form in forms)
                {
                    form.FormClosed += (s, args) =>
                    {
                        //When we have closed the last of the "starting" forms, 
                        //end the program.
                        if (Interlocked.Decrement(ref openForms) == 0)
                            ExitThread();
                    };

                    form.Show();
                }
            }
        }
    }
}
