using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Vurdalakov;

namespace Update.Maker.Source_files
{
    class Utils
    {

        public static int GetHash(string Name)
        {



            try
            {



                using (Stream stream = new FileStream(Name, FileMode.Open, FileAccess.Read, FileShare.Read))
                {

                    UInt32 hash;
                    CRC32Managed crc32Managed = new CRC32Managed();
                    crc32Managed.ComputeHash(stream);

                    hash = crc32Managed.CRC32Hash;
                    //Console.WriteLine("{0}", hash);
                    return (int)hash;


                }




            }





            catch
            {
                MessageBox.Show("Can't open: " + Name);
                return 0;
            }


            //    return input;
        }
    }
}
