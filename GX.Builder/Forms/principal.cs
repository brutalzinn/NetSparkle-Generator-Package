
using System;
using System.IO;
using System.Windows.Forms;
using System.Security;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using Cyclic.Redundancy.Check;
using Vurdalakov;
using System.Runtime.InteropServices;
using Update.Maker.Source_files;
using System.Text;
using MadMilkman.Ini;
using System.Drawing;
using System.Net;
using System.Data;
using System.Linq;
using NetSparkleUpdater.AppCastGenerator;

namespace Update.Maker
{
 
    public partial class principal : Form
    {
        string file_path_launcher_update;
        string[] Files;
        string path_to_remove;

        public static List<string> finded_files;
        DataTable dtSales = new DataTable();

        public principal()
        {
            InitializeComponent();
            Globals.principal = this;

          
           
        }
       
        private void browseButton_Click(object sender, EventArgs e)
        {
            dtSales.Rows.Clear();
            //dtSales.Refresh();
            Globals.contagem_files = 0;
            log(Globals.code.GERENCIADOR, "Arquivos listados.");
            StartBrowsing();

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveList();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
  
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Files = GetFiles(e.Argument);

            for (int i = 0; i < Files.Length; i++)
            {
                backgroundWorker.ReportProgress(i + 1, GetFileData(Files[i]));
            }
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            UpdateResult(e.UserState);

            UpdateProgressBar(ComputeProgress(e.ProgressPercentage));
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            EnableButtons();
        }

        private void DisableButtons()
        {
            Progress.Value = 0;
      //      Result.Clear();
           // saveButton.Enabled   = false;
         
            browseButton.Enabled = false;
        }

        private void EnableButtons()
        {
            saveButton.Enabled   = true;

            browseButton.Enabled = true;
        }

        public string[] GetFiles(object Path)
        {
            return Directory.GetFiles(Path.ToString(), "*.*", System.IO.SearchOption.AllDirectories);
        }
        private static string[] _operatingSystems = new string[] { "windows", "mac", "linux" };
        private static SignatureManager _signatureManager = new SignatureManager();
        public int GetFilesCount(string[] Files)
        {
            return Files.Length;
        }

        public string GetFileData(string File)
        {
            FileInfo fileInfo = new FileInfo(File);

            return File + "|" + _signatureManager.VerifySignature(File) + "|" + fileInfo.Length;
        }
        private ushort Crc16Ccitt(byte[] bytes)
        {
            const ushort poly = 4129;
            ushort[] table = new ushort[256];
            ushort initialValue = 0xffff;
            ushort temp, a;
            ushort crc = initialValue;
            for (int i = 0; i < table.Length; ++i)
            {
                temp = 0;
                a = (ushort)(i << 8);
                for (int j = 0; j < 8; ++j)
                {
                    if (((temp ^ a) & 0x8000) != 0)
                        temp = (ushort)((temp << 1) ^ poly);
                    else
                        temp <<= 1;
                    a <<= 1;
                }
                table[i] = temp;
            }
            for (int i = 0; i < bytes.Length; ++i)
            {
                crc = (ushort)((crc << 8) ^ table[((crc >> 8) ^ (0xff & bytes[i]))]);
            }
            return crc;
        }
        public static byte[] ReadToEnd(System.IO.Stream stream)
        {
            long originalPosition = 0;

            if (stream.CanSeek)
            {
                originalPosition = stream.Position;
                stream.Position = 0;
            }

            try
            {
                byte[] readBuffer = new byte[4096];

                int totalBytesRead = 0;
                int bytesRead;

                while ((bytesRead = stream.Read(readBuffer, totalBytesRead, readBuffer.Length - totalBytesRead)) > 0)
                {
                    totalBytesRead += bytesRead;

                    if (totalBytesRead == readBuffer.Length)
                    {
                        int nextByte = stream.ReadByte();
                        if (nextByte != -1)
                        {
                            byte[] temp = new byte[readBuffer.Length * 2];
                            Buffer.BlockCopy(readBuffer, 0, temp, 0, readBuffer.Length);
                            Buffer.SetByte(temp, totalBytesRead, (byte)nextByte);
                            readBuffer = temp;
                            totalBytesRead++;
                        }
                    }
                }

                byte[] buffer = readBuffer;
                if (readBuffer.Length != totalBytesRead)
                {
                    buffer = new byte[totalBytesRead];
                    Buffer.BlockCopy(readBuffer, 0, buffer, 0, totalBytesRead);
                }
                return buffer;
            }
            finally
            {
                if (stream.CanSeek)
                {
                    stream.Position = originalPosition;
                }
            }
        }
     

        private void UpdateResult(object Data)
        {
           
            if (!dataGridView1.IsDisposed)
            {
                var result = Data.ToString().Replace(@"\", @"/").Split('|');



                if(Data.ToString() != "")
                {



                    if(  isRaR(result[0]) == false){

                    
                        //string result_filter = result[0].Replace(Application.StartupPath, "");
                        Debug.WriteLine("OLD : " + result[0]);
                        //Debug.WriteLine("DEBUG: " + Application.StartupPath);
                        //string result_teste = result[0].Replace((Application.StartupPath + @"\update\").Replace(@"\",@"/"),"");
                        dtSales.Rows.Add(Globals.contagem_files++, Path.GetFileName(result[0]), result[0], result[2],result[1]);
                       

                    }


                  








                }
 

            }
        }

        private void UpdateModResult(object Data)
        {
            if (!dataGridView2.IsDisposed)
            {
                var result = Data.ToString().Replace(@"\", @"/").Split('|');



                if (Data.ToString() != "")
                {



                    

                        //string result_filter = result[0].Replace(Application.StartupPath, "");
                        Debug.WriteLine("OLD : " + result[0]);
                        //Debug.WriteLine("DEBUG: " + Application.StartupPath);
                        //string result_teste = result[0].Replace((Application.StartupPath + @"\update\").Replace(@"\",@"/"),"");
                        dataGridView2.Rows.Add(Path.GetFileName(result[0]), result[1]);


                    











                }
            }
        }
        static bool isRaR(string f)
        {

            return (f.EndsWith(".rar", StringComparison.OrdinalIgnoreCase));

            

        }
        private int ComputeProgress(int Percent)
        {
            return (100 * Percent) / Files.Length;
        }

        private void UpdateProgressBar(int Percent)
        {
            if (Percent < 0 || Percent > 100)
                return;

            if(!Progress.IsDisposed)
            {
                Progress.Value = Percent;
            }
        }

        private void RemoveFromPath(string Remove)
        {
            if (Remove == string.Empty)
                return;

            //Result.Text = Result.Text.Replace(Remove, string.Empty);
        

        }

        private void StartBrowsing()
        {
            //if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            //{
             DisableButtons();
            path_to_remove = Application.StartupPath.Replace(@"\", "/");//folderBrowserDialog.SelectedPath.Replace(@"\", "/");

                if(!backgroundWorker.IsBusy)
                {
                    backgroundWorker.RunWorkerAsync(Application.StartupPath + @"\update");
                }
            //}
        }

        private void SaveList()
        {
            //saveFileDialog.FileName = "update.muonline";
            //saveFileDialog.Filter = "Text files (*.txt)|*.txt|Every file (*.*)|*.*";
          
            //if (saveFileDialog.ShowDialog() == DialogResult.OK)
            //{
             
                using (System.IO.StreamWriter fileDifferent =
           new System.IO.StreamWriter(Application.StartupPath + @"\update.survivalcrafters"))
                {
                fileDifferent.WriteLine("[UPDATE]");
                fileDifferent.WriteLine("total=" + Globals.contagem_files);
                Globals.contagem_files = 0;
                path_to_remove = Application.StartupPath.Replace(@"\", "/");
                foreach (DataGridViewRow dataGridViewRow in dataGridView1.Rows)
                    {




            
                        // If the line doesn't contain the word 'Second', write the line to the file.
                                  
              
                    if (Convert.ToString(dataGridViewRow.Cells["diretorio"].Value) != "" && Convert.ToString(dataGridViewRow.Cells["crc"].Value) != "" && Convert.ToString(dataGridViewRow.Cells["size"].Value) != "")
                    {

                        
                        fileDifferent.WriteLine("[" + (Globals.contagem_files) + "]");
                        fileDifferent.WriteLine("caminho=" + Convert.ToString(dataGridViewRow.Cells["diretorio"].Value).Replace(path_to_remove + "/update/", string.Empty));
                    fileDifferent.WriteLine("crc32=" + Convert.ToString(dataGridViewRow.Cells["crc"].Value));
                        fileDifferent.WriteLine("len=" + Convert.ToString(dataGridViewRow.Cells["size"].Value));
                        Globals.contagem_files++;
                  //      Debug.WriteLine(Convert.ToString(dataGridViewRow.Cells["diretorio"].Value).Replace(path_to_remove + "/update/", string.Empty));
                    }
                    

                    }
                }


           File.Copy(Application.StartupPath + @"\update.survivalcrafters", Application.StartupPath + @"\listas\" + "update" + DateTime.Now.ToString("MM.dd.yyyy.HH.mm.ss") + ".survivalcrafters");
    //        Debug.WriteLine(Application.StartupPath + @"\listas\" + "update" + DateTime.Now.ToString("MM.dd.yyyy.HH.mm.ss") + ".survivalcrafters");
            //}
        }

        private void SaveList_MOD_LIST()
        {
            //saveFileDialog.FileName = "update.muonline";
            //saveFileDialog.Filter = "Text files (*.txt)|*.txt|Every file (*.*)|*.*";

            //if (saveFileDialog.ShowDialog() == DialogResult.OK)
            //{
            if (!Directory.Exists("launcher"))
            {
                Directory.CreateDirectory("launcher");

            }
            using (System.IO.StreamWriter fileDifferent =
       new System.IO.StreamWriter(Application.StartupPath + @"\launcher\white_list.txt"))
            {
  
 
              
                foreach (DataGridViewRow dataGridViewRow in dataGridView2.Rows)
                {





                    // If the line doesn't contain the word 'Second', write the line to the file.


                    if (Convert.ToString(dataGridViewRow.Cells["Mod"].Value) != "" && Convert.ToString(dataGridViewRow.Cells["CRC_MOD"].Value) != "" )
                    {


                   
                        fileDifferent.WriteLine(Convert.ToString(dataGridViewRow.Cells["Mod"].Value + "|" + Convert.ToString(dataGridViewRow.Cells["CRC_MOD"].Value)));

              
                   
                        //      Debug.WriteLine(Convert.ToString(dataGridViewRow.Cells["diretorio"].Value).Replace(path_to_remove + "/update/", string.Empty));
                    }


                }
            }


          //  File.Copy(Application.StartupPath + @"\update.survivalcrafters", Application.StartupPath + @"\listas\" + "update" + DateTime.Now.ToString("MM.dd.yyyy.HH.mm.ss") + ".survivalcrafters");
            //        Debug.WriteLine(Application.StartupPath + @"\listas\" + "update" + DateTime.Now.ToString("MM.dd.yyyy.HH.mm.ss") + ".survivalcrafters");
            //}
        }
        private const string RAR_PATH = @"rar.exe";
        //Package files.
        private void RarFiles(string rarPackagePath, List<string> files)
        {


            for (int i = 0; i < files.Count; i++)
            {
                files[0] = string.Format("\"{0}\"", files[i]);
            }
            string fileList = string.Join(" ", files.ToArray());
            // -cl
            string cmdArgs = string.Format("-ac -df -ep -m5 A {0} {1}",
                String.Format("\"{0}\"", rarPackagePath),
                fileList);
            Process.Start(String.Format("\"{0}\"", RAR_PATH), cmdArgs);
        }
        private void ChangeLine(string name)
        {

            

          
        }
        private static void Button1_Click(object sender, EventArgs e)
        {
  
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
     
        private void LForm_Load(object sender, EventArgs e)
        {
            license teste = new license();
          teste.Start(Globals.ByForm.principal.ToString());
            dtSales.Columns.Add("id", typeof(string));
            dtSales.Columns.Add("arquivo", typeof(string));
            dtSales.Columns.Add("diretorio", typeof(string));
            dtSales.Columns.Add("size", typeof(string));
            dtSales.Columns.Add("crc", typeof(string));
            dataGridView1.DataSource = dtSales;
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {

            log(Globals.code.GERENCIADOR, "Compactando arquivos para a atualização.");
            var file_ini = new List<string>() { Application.StartupPath +@"\" + Globals.nome_arquivo };
            RarFiles(Application.StartupPath + @"\update\" + Globals.nome_arquivo + ".rar", file_ini);

      

            foreach (DataGridViewRow dataGridViewRow in dataGridView1.Rows)
            {




            if(Convert.ToString(dataGridViewRow.Cells["diretorio"].Value) != "")
                {
                  if(  File.Exists(Convert.ToString(dataGridViewRow.Cells["diretorio"].Value) + ".rar") == false ){

var files_rar = new List<string>() { Convert.ToString(dataGridViewRow.Cells["diretorio"].Value)  };
               RarFiles(Convert.ToString(dataGridViewRow.Cells["diretorio"].Value)  + ".rar" , files_rar);



                    }
 
                }
              

            }


        }
        private void remover_Espacos_list()
        {



            for (int i = this.dataGridView1.Rows.Count - 1; i >= 0; i--)
            {
                bool isBlank = true;
                DataGridViewRow row = this.dataGridView1.Rows[i];
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString() != "")
                    {
                        isBlank = false;
                        break;
                    }
                }
                if (isBlank)
                {
                    this.dataGridView1.Rows.Remove(row);
                }
            }

        
    }
        private void Atualizar_list_Click(object sender, EventArgs e)
        {
     //       dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
        }

        private void Carregar_list_Click(object sender, EventArgs e)
        {





            IniFile ini = new IniFile();
            ini.Load("update.survivalcrafters");
           // int? i = 0;


            foreach (IniSection section in ini.Sections)
            {
                string sectionName = "";
                string keyName = "";
                string keyValue = "";
                foreach (IniKey key in section.Keys)
                {
                    sectionName = section.Name;
                    keyName = key.Name;


                    if (keyName != "total")
                    {

                        keyValue += key.Value + "|";
                  

                    }
                    else
                    {

                        keyValue = "";
                        Globals.contagem_files = -1;

                    }


                    
                  

                    // Do something ...
                }

                //               Console.WriteLine(sectionName + " " + keyValue);


                // if(value.Length)














                char[] MyChar = { '|' };

                // remove carcteres especiais
             
           


                string NewString = keyValue.TrimEnd(MyChar);
               string[] ini_value = NewString.Split('|');
                //  Console.WriteLine(partes[2]);
                if (Globals.contagem_files >= 0)
                {


                    dtSales.Rows.Add(Globals.contagem_files, Path.GetFileName(ini_value[0]) , Application.StartupPath.Replace(@"\",@"/") + "/update/" +ini_value[0] ,ini_value[2], ini_value[1]);
                    Debug.WriteLine("1" + ini_value[1]);
                    Debug.WriteLine("2" + ini_value[2]);

                }



                // var diretorio = ini_value[0];
                // var crc = ini_value[1];

                //var size = ini_value[2];
                Console.WriteLine(NewString);
                Globals.contagem_files++;





                //remover_Espacos_list();



















            }
         

        }
        private void MOD_LOAD_LIST()
        {



            foreach (string line in File.ReadLines(Application.StartupPath + @"\launcher\white_list.txt")) 
            {
                string[] ini_value = line.Split('|');
                dataGridView2.Rows.Add(ini_value[0], ini_value[1]);
                
            }


            








            }

        private void Item_Click(object sender, EventArgs e)
        {

        }

        private void Menu_options_Opening(object sender, CancelEventArgs e)
        {

        }

        private void Arquivo_context_add_menu_Click(object sender, EventArgs e)
        {
       

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
   
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.ReadOnlyChecked = true;
            openFileDialog1.ShowReadOnly = true;

            openFileDialog1.Multiselect = true;
            openFileDialog1.Title = "Selecionar Arquivos";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                foreach (String arquivo in openFileDialog1.FileNames)
                {


                    log(Globals.code.GERENCIADOR, "O arquivo " + Path.GetFileName(arquivo) + " foi adicionado"); 




                    //row.Cells["chat1"].Style.ForeColor = Color.CadetBlue;

                    
                            foreach (DataGridViewRow dataGridViewRow in dataGridView1.Rows)
                            {

                                string crc_list = Convert.ToString(dataGridViewRow.Cells["crc"].Value);
                                string arquivo_list = Convert.ToString(dataGridViewRow.Cells["arquivo"].Value);






                                // If the line doesn't contain the word 'Second', write the line to the file.







                                if (Path.GetFileName(arquivo) == arquivo_list && crc_list != Convert.ToString(Utils.GetHash(arquivo)))
                                {

                            log(Globals.code.GERENCIADOR, "O arquivo antigo " + Path.GetFileName(arquivo) + " foi substituido pelo novo "+ Path.GetFileName(arquivo));

                            var resultinfo = GetFileData(arquivo.Replace(@"\",@"/")).Split('|');




                            DataGridViewRow newDataRow = dataGridView1.Rows[dataGridViewRow.Index];
                            newDataRow.Cells[0].Value = Globals.contagem_files - 1;
                            newDataRow.Cells[1].Value = Path.GetFileName(arquivo);
                            newDataRow.Cells[2].Value = resultinfo[0];


                            newDataRow.Cells[3].Value = resultinfo[2];
                            newDataRow.Cells[4].Value = resultinfo[1];
                     
                            break;
                            //log("Arquivo:" + Path.GetFileName(arquivo) + " Foi atualizado. " + "crc" + dataGridViewRow.Cells["crc"].Value + "para" + GetHash(arquivo));
                        }
                        else
                        {
                            UpdateResult(GetFileData(arquivo));
                            break;

                        }

                            }



       




                }


            }
        }
        public void log(Globals.code resposta, string info)
        {

            log_list.AppendText(DateTime.Now + "["+resposta + "]:" + " " + info + Environment.NewLine);



        }
        private void RemovearquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewSelectedRowCollection row = dataGridView1.SelectedRows;
                Globals.contagem_files = dataGridView1.SelectedRows[0].Index;
                // taking the index of the selected rows and removing/
                dtSales.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
            else
            {  //optional    
                MessageBox.Show("Selecione um arquivo");
            }

        }
        private void removerMod_LIST()
        {


            if (dataGridView2.SelectedRows.Count > 0)
            {
                DataGridViewSelectedRowCollection row = dataGridView2.SelectedRows;
          
                // taking the index of the selected rows and removing/
                dataGridView2.Rows.RemoveAt(dataGridView2.SelectedRows[0].Index);
            }
            else
            {  //optional    
                MessageBox.Show("Selecione um arquivo");
            }

        }

        private void LimparListaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Você deseja realmente limpar a lista?.", Globals.application_name + " Limpar lista", MessageBoxButtons.YesNo,
      MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                dataGridView1.Rows.Clear();


                // Do something
            }


        }

        private void DesenvolvidoPorRobertinhonetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://robertinho.net");
        }

        private void Button2_Click(object sender, EventArgs e)
        {

       

        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
         Environment.Exit(0);

        }

        private void RecalcularToolStripMenuItem_Click(object sender, EventArgs e)
        {

           List<string> files_crc = new List<string>();
         List<string> files_size = new List<string>();
        Globals.contagem_files = -1;
            foreach (DataGridViewRow dataGridViewRow in dataGridView1.Rows)
            {
                DataGridViewRow newDataRow = dataGridView1.Rows[dataGridViewRow.Index];
                if(newDataRow.Cells[0].Value != null)
                {
Globals.contagem_files++;
            newDataRow.Cells[0].Value = Globals.contagem_files;

                }
                else
                {
                    Globals.contagem_files++;

                }



               
                
              
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dataGridViewRow in dataGridView1.Rows)
            {

                DataGridViewRow newDataRow = dataGridView1.Rows[dataGridViewRow.Index];
                //  newDataRow.Cells[2].Value

                ftp_upload(newDataRow.Cells[2].Value.ToString());
            }
              



        }
        private static void ftp_upload(string filename)
        {


            FtpWebRequest request =
  (FtpWebRequest)WebRequest.Create("ftp://ftp.robertinho.net/" + Path.GetFileName(filename));
            request.Credentials = new NetworkCredential("update.minecraft@update.robertinho.net", "Garfield_009");
            request.Method = WebRequestMethods.Ftp.UploadFile;

            using (Stream fileStream = File.OpenRead(filename))
            using (Stream ftpStream = request.GetRequestStream())
            {
                byte[] buffer = new byte[10240];
                int read;
                while ((read = fileStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    ftpStream.Write(buffer, 0, read);
                    Console.WriteLine("Uploaded {0} bytes", fileStream.Position);
                }
            }

        }
        private void MOD_LIST_add()
        {


            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.ReadOnlyChecked = true;
            openFileDialog1.ShowReadOnly = true;

            openFileDialog1.Multiselect = true;
            openFileDialog1.Title = "Selecionar Arquivos";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                foreach (String arquivo in openFileDialog1.FileNames)
                {


                    log(Globals.code.GERENCIADOR, "O mod foi adicionado " + Path.GetFileName(arquivo) + " foi adicionado");




                    //row.Cells["chat1"].Style.ForeColor = Color.CadetBlue;


                    foreach (DataGridViewRow dataGridViewRow in dataGridView2.Rows)
                    {

                        string crc_list = Convert.ToString(dataGridViewRow.Cells["Mod"].Value);
                        string arquivo_list = Convert.ToString(dataGridViewRow.Cells["CRC_MOD"].Value);






                        // If the line doesn't contain the word 'Second', write the line to the file.







                        if (Path.GetFileName(arquivo) == arquivo_list && crc_list != Convert.ToString(Utils.GetHash(arquivo)))
                        {

                            log(Globals.code.GERENCIADOR, "O arquivo antigo " + Path.GetFileName(arquivo) + " foi substituido pelo novo " + Path.GetFileName(arquivo));

                            var resultinfo = GetFileData(arquivo.Replace(@"\", @"/")).Split('|');




                            DataGridViewRow newDataRow = dataGridView2.Rows[dataGridViewRow.Index];
                            newDataRow.Cells[0].Value = Path.GetFileName(arquivo);
                            newDataRow.Cells[1].Value = resultinfo[2];


                            
                            break;
                            //log("Arquivo:" + Path.GetFileName(arquivo) + " Foi atualizado. " + "crc" + dataGridViewRow.Cells["crc"].Value + "para" + GetHash(arquivo));
                        }
                        else
                        {
                            UpdateModResult(GetFileData(arquivo));
                            break;

                        }

                    }








                }


            }
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            MOD_LIST_add();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = Application.StartupPath,
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "exe",
                Filter = "txt files (*.exe)|*.exe",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                file_path_launcher_update = openFileDialog1.FileName;
                textBox1.Text = Path.GetFileName(file_path_launcher_update);

                label9.Text = "CRC: " + Utils.GetHash(file_path_launcher_update).ToString();

                
                    FileInfo fileInfo = new FileInfo(file_path_launcher_update);
                label10.Text = "Tamanho:" + fileInfo.Length.ToString();
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {

           string arquivo = Path.GetFileName(file_path_launcher_update);

         string crc = Utils.GetHash(file_path_launcher_update).ToString();
            FileInfo fileInfo = new FileInfo(file_path_launcher_update);
           string size = fileInfo.Length.ToString();


            string text = arquivo + "|" + crc + "|" + size;
            // WriteAllText creates a file, writes the specified string to the file,
            // and then closes the file.    You do NOT need to call Flush() or Close().
            if (!Directory.Exists("launcher"))
            {
                Directory.CreateDirectory("launcher");

            }
            System.IO.File.WriteAllText(Application.StartupPath + @"\launcher\launcherupdate.txt", text);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists("launcher"))
            {
                Directory.CreateDirectory("launcher");

            }
            string text =  textBox2.Text + "|" + textBox3.Text + "|" + Convert.ToString(checkBox1.Checked ? 1 : 0 );
            System.IO.File.WriteAllText(Application.StartupPath + @"\launcher\manutence.txt", text);
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            removerMod_LIST();
        }

        private void Button9_Click(object sender, EventArgs e)
        {



            SaveList_MOD_LIST();

        }

        private void Button10_Click(object sender, EventArgs e)
        {
            MOD_LOAD_LIST();
        }

        private void Progress_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click_1(object sender, EventArgs e)
        {

            RadioButton radioBtn = this.Controls.OfType<RadioButton>()
                                        .Where(x => x.Checked).FirstOrDefault();
            if (radioBtn != null)
            {
                switch (radioBtn.Name)
                {
                    case "finder_fixo":
                        (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("arquivo = '{0}'", textBoxSearch.Text);

                        break;
                    case "finder_file":
                        dtSales.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "arquivo", textBoxSearch.Text);
                        break;

                    case "finder_directory":
                        dtSales.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "diretorio", textBoxSearch.Text);
                        break;



                }

            }


        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {


            if (finder_fixo.Checked)
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("arquivo = '{0}'", textBoxSearch.Text);

            }
            else if (finder_file.Checked)
            {
                dtSales.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "arquivo", textBoxSearch.Text);

            }
            else if (finder_directory.Checked)
            {
                dtSales.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "diretorio", textBoxSearch.Text);

            }
                 



                }

        private void ListarPastaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var dialog = new System.Windows.Forms.FolderBrowserDialog())
            {
                //      fbd.SelectedPath = Application.StartupPath;
                System.Windows.Forms.DialogResult result = dialog.ShowDialog();

                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    string[] files = Directory.GetFiles(dialog.SelectedPath);
                    Debug.WriteLine("Chamou");

                    foreach (string arquivo in files)
                    {
                        Debug.WriteLine("Chamou" + arquivo);


                        log(Globals.code.GERENCIADOR, "O arquivo " + Path.GetFileName(arquivo) + " foi adicionado");




                        //row.Cells["chat1"].Style.ForeColor = Color.CadetBlue;


                        foreach (DataGridViewRow dataGridViewRow in dataGridView1.Rows)
                        {

                            string crc_list = Convert.ToString(dataGridViewRow.Cells["crc"].Value);
                            string arquivo_list = Convert.ToString(dataGridViewRow.Cells["arquivo"].Value);






                            // If the line doesn't contain the word 'Second', write the line to the file.







                            if (Path.GetFileName(arquivo) == arquivo_list && crc_list != Convert.ToString(Utils.GetHash(arquivo)))
                            {

                                log(Globals.code.GERENCIADOR, "O arquivo antigo " + Path.GetFileName(arquivo) + " foi substituido pelo novo " + Path.GetFileName(arquivo));

                                var resultinfo = GetFileData(arquivo.Replace(@"\", @"/")).Split('|');




                                DataGridViewRow newDataRow = dataGridView1.Rows[dataGridViewRow.Index];
                                newDataRow.Cells[0].Value = Globals.contagem_files - 1;
                                newDataRow.Cells[1].Value = Path.GetFileName(arquivo);
                                newDataRow.Cells[2].Value = resultinfo[0];


                                newDataRow.Cells[3].Value = resultinfo[2];
                                newDataRow.Cells[4].Value = resultinfo[1];

                                break;
                                //log("Arquivo:" + Path.GetFileName(arquivo) + " Foi atualizado. " + "crc" + dataGridViewRow.Cells["crc"].Value + "para" + GetHash(arquivo));
                            }
                            else
                            {
                                UpdateResult(GetFileData(arquivo));
                                break;

                            }

                        }








                    }
                }
            }
































        }
    }

        }
    
