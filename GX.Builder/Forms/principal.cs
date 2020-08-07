
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
using NetSparkleUpdater;
using System.Web;
using NetSparkleUpdater.AppCastHandlers;
using System.Xml;
using NetSparkleUpdater.Interfaces;
using System.Xml.Linq;
using Update.Maker.Forms;
using System.Text.RegularExpressions;

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
            saveButton.Enabled = true;

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

            return File + "|" + _signatureManager.GetSignatureForFile(File) + "|" + fileInfo.Length;
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



                if (Data.ToString() != "")
                {



                    if (isRaR(result[0]) == false) {


                        //string result_filter = result[0].Replace(Application.StartupPath, "");
                        Debug.WriteLine("OLD : " + result[0]);
                        //Debug.WriteLine("DEBUG: " + Application.StartupPath);
                        //string result_teste = result[0].Replace((Application.StartupPath + @"\update\").Replace(@"\",@"/"),"");
                        dtSales.Rows.Add(Globals.contagem_files++, Path.GetFileName(result[0]), result[0], result[2], result[1],"1.0.0.0", Path.GetFileName(result[0]),"","", "", "" ,"", "", "", "", false);


                    }











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

            if (!Progress.IsDisposed)
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

            if (!backgroundWorker.IsBusy)
            {
                backgroundWorker.RunWorkerAsync(Application.StartupPath + @"\update");
            }
            //}
        }

        private void SaveList()
        {
   
                foreach (DataGridViewRow dataGridViewRow in dataGridView1.Rows)
                {

                    if (Convert.ToString(dataGridViewRow.Cells["directory"].Value) != "" && Convert.ToString(dataGridViewRow.Cells["hash"].Value) != "" && Convert.ToString(dataGridViewRow.Cells["size"].Value) != "")
                    {




                        CreateXML(dataGridViewRow.Cells["file"].Value.ToString(), textBox1.Text, Convert.ToBoolean(dataGridViewRow.Cells["isprefixed"].Value), dataGridViewRow.Cells["version"].Value.ToString(), new FileInfo(dataGridViewRow.Cells["directory"].Value.ToString()), dataGridViewRow.Cells["systemos"].Value.ToString(), dataGridViewRow.Cells["changelogfilepath"].Value.ToString(), dataGridViewRow.Cells["changelogurl"].Value.ToString());
                        //fileDifferent.WriteLine("[" + (Globals.contagem_files) + "]");
                        //fileDifferent.WriteLine("caminho=" + Convert.ToString(dataGridViewRow.Cells["diretorio"].Value).Replace(path_to_remove + "/update/", string.Empty));
                        //fileDifferent.WriteLine("crc32=" + Convert.ToString(dataGridViewRow.Cells["crc"].Value));
                        //fileDifferent.WriteLine("len=" + Convert.ToString(dataGridViewRow.Cells["size"].Value));
                        //Globals.contagem_files++;
                        //      Debug.WriteLine(Convert.ToString(dataGridViewRow.Cells["diretorio"].Value).Replace(path_to_remove + "/update/", string.Empty));
                    }


                }

            XmlGenerator();
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

  public static List<AppCastItem> Items = new List<AppCastItem>();
        public static List<AppCastItem> Items_to_write= new List<AppCastItem>();
        public  void CreateXML(string productName, string BaseUrl, bool PrefixVersion , string version, FileInfo fileInfo, string operationsystem, string changelogpath,string changlogurl)
        {
           

            try
            {


                var productVersion = version;
                var usesChangelogs = !string.IsNullOrWhiteSpace(changelogpath) && Directory.Exists(changelogpath);
               
                var itemTitle = string.IsNullOrWhiteSpace(productName) ? productVersion : productName + " " + productVersion;
                var remoteUpdateFile = $"{BaseUrl}/{(PrefixVersion ? $"{version}/" : "")}{HttpUtility.UrlEncode(fileInfo.Name)}";

                // changelog stuff
                var changelogFileName = productVersion + ".md";
                var changelogPath = Path.Combine(changelogpath, changelogFileName);
                var hasChangelogForFile = usesChangelogs && File.Exists(changelogPath);
                var changelogSignature = "";

                if (hasChangelogForFile)
                {
                    changelogSignature = _signatureManager.GetSignatureForFile(changelogPath);
                }
                //
                var item = new AppCastItem()
                {
                    Title = itemTitle,
                    DownloadLink = remoteUpdateFile,
                    Version = productVersion,
                    ShortVersion = productVersion.Substring(0, productVersion.LastIndexOf('.')),
                    PublicationDate = fileInfo.CreationTime,
                    UpdateSize = fileInfo.Length,
                    Description = "",
                    DownloadSignature = _signatureManager.KeysExist() ? _signatureManager.GetSignatureForFile(fileInfo) : null,
                    OperatingSystemString = operationsystem,
                    MIMEType = MimeTypes.GetMimeType(fileInfo.Name)
                };

                if (hasChangelogForFile)
                {
                    if (!string.IsNullOrWhiteSpace(changlogurl))
                    {
                        item.ReleaseNotesSignature = changelogSignature;
                        item.ReleaseNotesLink = changlogurl + changelogFileName;
                    }
                    else
                    {
                        item.Description = File.ReadAllText(changelogPath);
                    }
                }

                Items_to_write.Add(item);
              
               
               

        }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine();
                Environment.Exit(1);

            }
        }
        static string GetVersionFromName(FileInfo fileInfo)
        {
            var regexPattern = @"\d+(\.\d+)+";
            var regex = new Regex(regexPattern);

            var match = regex.Match(fileInfo.FullName);

            return match.Captures[match.Captures.Count - 1].Value; // get the numbers at the end of the string incase the app is something like 1.0application1.0.0.dmg
        }

        static string GetVersionFromAssembly(FileInfo fileInfo)
        {
            return FileVersionInfo.GetVersionInfo(fileInfo.FullName).ProductVersion;
        }
        public void XmlGenerator()
        {
            var appcastFileName = Path.Combine(Application.StartupPath + @"\output\", "appcast.xml");
            if (File.Exists(appcastFileName))
            {
                File.Delete(appcastFileName);
            }
            var appcastXmlDocument = XMLAppCast.GenerateAppCastXml(Items_to_write, textBox1.Text );


           
            var dirName = Path.GetDirectoryName(appcastFileName);

            if (!Directory.Exists(dirName))
            {
                Console.WriteLine("Creating {0}", dirName);
                Directory.CreateDirectory(dirName);
            }

            Console.WriteLine("Writing appcast to {0}", appcastFileName);

            using (var w = XmlWriter.Create(appcastFileName, new XmlWriterSettings { NewLineChars = "\n", Encoding = new UTF8Encoding(false) }))
            {
                appcastXmlDocument.Save(w);
            }

            if (_signatureManager.KeysExist())
            {
                var appcastFile = new FileInfo(appcastFileName);
                var signatureFile = appcastFileName + ".signature";
                var signature = _signatureManager.GetSignatureForFile(appcastFile);

                var result = _signatureManager.VerifySignature(appcastFile, signature);

                if (result)
                {

                    File.WriteAllText(signatureFile, signature);
                    Console.WriteLine($"Wrote {signatureFile}", Color.Green);
                }
                else
                {
                    Console.WriteLine($"Failed to verify {signatureFile}", Color.Red);
                }

            }
            else
            {
                Console.WriteLine("Skipped generating signature.  Generate keys with --generate-keys", Color.Red);
                Environment.Exit(1);
            }
            Items_to_write.Clear();
        }

        private void LForm_Load(object sender, EventArgs e)
        {
            LoadDataGriedView();



        }
        public void LoadDataGriedView()
        {

            dtSales.Columns.Add("id", typeof(string));
            dtSales.Columns.Add("file", typeof(string));
            dtSales.Columns.Add("directory", typeof(string));
            dtSales.Columns.Add("size", typeof(string));
            dtSales.Columns.Add("hash", typeof(string));
            dtSales.Columns.Add("version", typeof(string));
            dtSales.Columns.Add("title", typeof(string));
            dtSales.Columns.Add("releasenote", typeof(string));
            dtSales.Columns.Add("link", typeof(string));
            dtSales.Columns.Add("shortversion", typeof(string));
            dtSales.Columns.Add("systemos", typeof(string));
            dtSales.Columns.Add("type", typeof(string));
            dtSales.Columns.Add("crtiticalupdate", typeof(string));

            dtSales.Columns.Add("changelogfilepath", typeof(string));
            dtSales.Columns.Add("changelogurl", typeof(string));
            dtSales.Columns.Add("isprefixed", typeof(string));
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
        public IAppCastHandler AppCastHandler { get; set; }
        private void ParseAppCast(string appcast)
        {
            const string itemNode = "item";
            Items.Clear();
            LogWriter _logWriter = new LogWriter();
            XDocument doc = XDocument.Parse(appcast);
            var rss = doc?.Element("rss");
            var channel = rss?.Element("channel");

            string Title = channel?.Element("title")?.Value ?? string.Empty;
          string  Language = channel?.Element("language")?.Value ?? "en";

            var items = doc.Descendants(itemNode);
            foreach (var item in items)
            {
                var currentItem = AppCastItem.Parse("", "", "", item, _logWriter);
                _logWriter.PrintMessage("Found an item in the app cast: version {0} ({1}) -- os = {2}",
                    currentItem?.Version, currentItem?.ShortVersion, currentItem.OperatingSystemString);
                Items.Add(currentItem);
            }

            // sort versions in reverse order
            Items.Sort((item1, item2) => -1 * item1.CompareTo(item2));
        }
        private void Carregar_list_Click(object sender, EventArgs e)
        {


           
          
            var appcastFileName = Path.Combine(Application.StartupPath + @"\output\", "appcast.xml");
            if (!File.Exists(appcastFileName))
            {
                return;
               
            }
                string input =  File.ReadAllText(appcastFileName);
            ParseAppCast(input);

            foreach (AppCastItem item in Items)
            {

                dtSales.Rows.Add(Globals.contagem_files, item.Title, Application.StartupPath.Replace(@"\", @"/") + "/update/" + item.Title, item.UpdateSize, item.DownloadSignature, item.Version);

                Globals.contagem_files++;
            }




           // dtSales.Rows.Add(Globals.contagem_files, Path.GetFileName(ini_value[0]), Application.StartupPath.Replace(@"\", @"/") + "/update/" + ini_value[0], ini_value[2], ini_value[1]);
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





                    
                            foreach (DataGridViewRow dataGridViewRow in dataGridView1.Rows)
                            {

                                string crc_list = Convert.ToString(dataGridViewRow.Cells["hash"].Value);
                                string arquivo_list = Convert.ToString(dataGridViewRow.Cells["directory"].Value);

                                if (Path.GetFileName(arquivo) == arquivo_list && crc_list != Convert.ToString(_signatureManager.GetSignatureForFile(arquivo)))
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
      

        private void LimparListaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Você deseja realmente limpar a lista?.", Globals.application_name + " Limpar lista", MessageBoxButtons.YesNo,
      MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                dtSales.Clear();
                dataGridView1.Refresh();
              



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

        private void editarLinhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                Globals.contagem_files = dataGridView1.SelectedRows[0].Index;
                // taking the index of the selected rows and removing/
                DataGridViewRow newDataRow = dataGridView1.SelectedRows[0];

                Items items = new Items();

                Formulario teste = new Formulario();
              
                    
                items.Id = Convert.ToInt32(newDataRow.Cells[1].Value);
                items.Title = newDataRow.Cells[2].Value.ToString();
                items.File = newDataRow.Cells[3].Value.ToString();
                items.Releasenote = newDataRow.Cells[4].Value.ToString();
                items.Link = newDataRow.Cells[5].Value.ToString();
                items.Version = newDataRow.Cells[6].Value.ToString();
                items.Shortversion = newDataRow.Cells[7].Value.ToString();
                items.System = newDataRow.Cells[8].Value.ToString();
                items.Type = newDataRow.Cells[9].Value.ToString();
                items.Criticalupdate = newDataRow.Cells[10].Value.ToString();
                items.Changelogpath = newDataRow.Cells[11].Value.ToString();
                items.Changelogurl = newDataRow.Cells[12].Value.ToString();
                items.Isprefixed = Convert.ToBoolean(newDataRow.Cells[13].Value);
                items.AndroidVersion = newDataRow.Cells[14].Value.ToString();
                items.AndroidVersionMaximum = newDataRow.Cells[15].Value.ToString();
                items.AndroidVersionMinimum = newDataRow.Cells[16].Value.ToString();



                teste.ShowDialog();
                //dtSales.Columns.Add("id", typeof(string));
                //dtSales.Columns.Add("file", typeof(string));
                //dtSales.Columns.Add("directory", typeof(string));
                //dtSales.Columns.Add("size", typeof(string));
                //dtSales.Columns.Add("hash", typeof(string));
                //dtSales.Columns.Add("version", typeof(string));
                //dtSales.Columns.Add("title", typeof(string));
                //dtSales.Columns.Add("releasenote", typeof(string));
                //dtSales.Columns.Add("link", typeof(string));
                //dtSales.Columns.Add("shortversion", typeof(string));
                //dtSales.Columns.Add("systemos", typeof(string));
                //dtSales.Columns.Add("type", typeof(string));
                //dtSales.Columns.Add("crtiticalupdate", typeof(string));
            }
            else
            {  //optional    
                MessageBox.Show("Selecione um arquivo");
            }









        }
    }

        }
    
