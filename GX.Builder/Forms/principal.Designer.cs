namespace Update.Maker
{
    partial class principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.browseButton = new System.Windows.Forms.Button();
            this.Progress = new System.Windows.Forms.ProgressBar();
            this.saveButton = new System.Windows.Forms.Button();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.Openfileadd = new System.Windows.Forms.OpenFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menu_options = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.atualizar_list = new System.Windows.Forms.ToolStripMenuItem();
            this.carregar_list = new System.Windows.Forms.ToolStripMenuItem();
            this.arquivo_context = new System.Windows.Forms.ToolStripMenuItem();
            this.arquivo_context_add_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.removearquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clear_list = new System.Windows.Forms.ToolStripMenuItem();
            this.recalcularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.log_list = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.desenvolvidoPorRobertinhonetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.license_text_show = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button_finder = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Mod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CRC_MOD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button7 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.finder_directory = new System.Windows.Forms.RadioButton();
            this.finder_file = new System.Windows.Forms.RadioButton();
            this.finder_fixo = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menu_options.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(94, 294);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(98, 31);
            this.browseButton.TabIndex = 1;
            this.browseButton.Text = "Listar";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // Progress
            // 
            this.Progress.Location = new System.Drawing.Point(8, 429);
            this.Progress.Name = "Progress";
            this.Progress.Size = new System.Drawing.Size(579, 34);
            this.Progress.TabIndex = 2;
            this.Progress.Click += new System.EventHandler(this.Progress_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(94, 341);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(98, 35);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Salvar Lista";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // Openfileadd
            // 
            this.Openfileadd.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.menu_options;
            this.dataGridView1.Location = new System.Drawing.Point(0, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(867, 250);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // menu_options
            // 
            this.menu_options.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atualizar_list,
            this.carregar_list,
            this.arquivo_context,
            this.clear_list,
            this.recalcularToolStripMenuItem});
            this.menu_options.Name = "menu_options";
            this.menu_options.ShowCheckMargin = true;
            this.menu_options.Size = new System.Drawing.Size(167, 114);
            this.menu_options.Opening += new System.ComponentModel.CancelEventHandler(this.Menu_options_Opening);
            // 
            // atualizar_list
            // 
            this.atualizar_list.Name = "atualizar_list";
            this.atualizar_list.Size = new System.Drawing.Size(166, 22);
            this.atualizar_list.Text = "Atualizar lista";
            this.atualizar_list.Click += new System.EventHandler(this.Atualizar_list_Click);
            // 
            // carregar_list
            // 
            this.carregar_list.Name = "carregar_list";
            this.carregar_list.Size = new System.Drawing.Size(166, 22);
            this.carregar_list.Text = "Carregar lista";
            this.carregar_list.Click += new System.EventHandler(this.Carregar_list_Click);
            // 
            // arquivo_context
            // 
            this.arquivo_context.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.arquivo_context.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivo_context_add_menu,
            this.removearquivoToolStripMenuItem});
            this.arquivo_context.ForeColor = System.Drawing.Color.White;
            this.arquivo_context.Name = "arquivo_context";
            this.arquivo_context.Size = new System.Drawing.Size(166, 22);
            this.arquivo_context.Text = "Arquivo";
            // 
            // arquivo_context_add_menu
            // 
            this.arquivo_context_add_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.arquivo_context_add_menu.Name = "arquivo_context_add_menu";
            this.arquivo_context_add_menu.Size = new System.Drawing.Size(180, 22);
            this.arquivo_context_add_menu.Text = "Adicionar arquivo";
            this.arquivo_context_add_menu.Click += new System.EventHandler(this.Arquivo_context_add_menu_Click);
            // 
            // removearquivoToolStripMenuItem
            // 
            this.removearquivoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.removearquivoToolStripMenuItem.Name = "removearquivoToolStripMenuItem";
            this.removearquivoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removearquivoToolStripMenuItem.Text = "Remover arquivo";
            this.removearquivoToolStripMenuItem.Click += new System.EventHandler(this.RemovearquivoToolStripMenuItem_Click);
            // 
            // clear_list
            // 
            this.clear_list.BackColor = System.Drawing.Color.Red;
            this.clear_list.ForeColor = System.Drawing.Color.White;
            this.clear_list.Name = "clear_list";
            this.clear_list.Size = new System.Drawing.Size(166, 22);
            this.clear_list.Text = "Limpar lista";
            this.clear_list.Click += new System.EventHandler(this.LimparListaToolStripMenuItem_Click);
            // 
            // recalcularToolStripMenuItem
            // 
            this.recalcularToolStripMenuItem.Name = "recalcularToolStripMenuItem";
            this.recalcularToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.recalcularToolStripMenuItem.Text = "Recalcular";
            this.recalcularToolStripMenuItem.Click += new System.EventHandler(this.RecalcularToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Location = new System.Drawing.Point(94, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 31);
            this.button1.TabIndex = 8;
            this.button1.Text = "GERAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // log_list
            // 
            this.log_list.Location = new System.Drawing.Point(609, 332);
            this.log_list.Name = "log_list";
            this.log_list.Size = new System.Drawing.Size(263, 134);
            this.log_list.TabIndex = 9;
            this.log_list.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(798, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "ETAPA - 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "ETAPA - 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "ETAPA - 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(726, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "LOGS";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.desenvolvidoPorRobertinhonetToolStripMenuItem,
            this.license_text_show});
            this.menuStrip1.Location = new System.Drawing.Point(0, 488);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(883, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // desenvolvidoPorRobertinhonetToolStripMenuItem
            // 
            this.desenvolvidoPorRobertinhonetToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.desenvolvidoPorRobertinhonetToolStripMenuItem.Name = "desenvolvidoPorRobertinhonetToolStripMenuItem";
            this.desenvolvidoPorRobertinhonetToolStripMenuItem.Size = new System.Drawing.Size(190, 20);
            this.desenvolvidoPorRobertinhonetToolStripMenuItem.Text = "Desenvolvido por robertinho.net";
            this.desenvolvidoPorRobertinhonetToolStripMenuItem.Click += new System.EventHandler(this.DesenvolvidoPorRobertinhonetToolStripMenuItem_Click);
            // 
            // license_text_show
            // 
            this.license_text_show.Name = "license_text_show";
            this.license_text_show.Size = new System.Drawing.Size(55, 20);
            this.license_text_show.Text = "license";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(883, 500);
            this.tabControl1.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.finder_fixo);
            this.tabPage1.Controls.Add(this.finder_file);
            this.tabPage1.Controls.Add(this.finder_directory);
            this.tabPage1.Controls.Add(this.button_finder);
            this.tabPage1.Controls.Add(this.textBoxSearch);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.saveButton);
            this.tabPage1.Controls.Add(this.log_list);
            this.tabPage1.Controls.Add(this.browseButton);
            this.tabPage1.Controls.Add(this.Progress);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(875, 474);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Principal";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.TabPage1_Click);
            // 
            // button_finder
            // 
            this.button_finder.Location = new System.Drawing.Point(793, 12);
            this.button_finder.Name = "button_finder";
            this.button_finder.Size = new System.Drawing.Size(74, 21);
            this.button_finder.TabIndex = 17;
            this.button_finder.Text = "Pesquisar";
            this.button_finder.UseVisualStyleBackColor = true;
            this.button_finder.Click += new System.EventHandler(this.Button2_Click_1);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(637, 12);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(150, 20);
            this.textBoxSearch.TabIndex = 16;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(411, 358);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(176, 56);
            this.button3.TabIndex = 15;
            this.button3.Text = "Enviar arquivos";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(875, 474);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Launcher";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button10);
            this.groupBox3.Controls.Add(this.button9);
            this.groupBox3.Controls.Add(this.button8);
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Location = new System.Drawing.Point(377, 47);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(468, 403);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "MODS LIBERADOS";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(261, 353);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(98, 43);
            this.button10.TabIndex = 13;
            this.button10.Text = "Abrir";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.Button10_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(365, 350);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(93, 46);
            this.button9.TabIndex = 12;
            this.button9.Text = "Salvar";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(138, 350);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(117, 47);
            this.button8.TabIndex = 11;
            this.button8.Text = "Remover mod";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mod,
            this.CRC_MOD});
            this.dataGridView2.Location = new System.Drawing.Point(15, 31);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(443, 313);
            this.dataGridView2.TabIndex = 10;
            // 
            // Mod
            // 
            this.Mod.HeaderText = "Mod";
            this.Mod.Name = "Mod";
            // 
            // CRC_MOD
            // 
            this.CRC_MOD.HeaderText = "CRC";
            this.CRC_MOD.Name = "CRC_MOD";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(15, 350);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 47);
            this.button4.TabIndex = 9;
            this.button4.Text = "Adicionar mod";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Location = new System.Drawing.Point(23, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 137);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sistema de manutenção";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Manutenção:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(83, 77);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(103, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Ativar/Desativar";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(235, 88);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(78, 34);
            this.button7.TabIndex = 6;
            this.button7.Text = "Salvar";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Mensagem:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Título:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(74, 47);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(229, 20);
            this.textBox3.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(74, 21);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(229, 20);
            this.textBox2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(23, 177);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 153);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Atualizar o launcher";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(155, 107);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(74, 37);
            this.button6.TabIndex = 7;
            this.button6.Text = "Abrir";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(235, 105);
            this.button5.Name = "button5";
            this.button5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button5.Size = new System.Drawing.Size(78, 41);
            this.button5.TabIndex = 6;
            this.button5.Text = "Salvar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(72, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Tamanho";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(71, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "CRC: 0000000";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(74, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(229, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Nome. EXE";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(890, 431);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 18;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // finder_directory
            // 
            this.finder_directory.AutoSize = true;
            this.finder_directory.Location = new System.Drawing.Point(519, 12);
            this.finder_directory.Name = "finder_directory";
            this.finder_directory.Size = new System.Drawing.Size(62, 17);
            this.finder_directory.TabIndex = 18;
            this.finder_directory.TabStop = true;
            this.finder_directory.Text = "diretório";
            this.finder_directory.UseVisualStyleBackColor = true;
            // 
            // finder_file
            // 
            this.finder_file.AutoSize = true;
            this.finder_file.Location = new System.Drawing.Point(439, 12);
            this.finder_file.Name = "finder_file";
            this.finder_file.Size = new System.Drawing.Size(61, 17);
            this.finder_file.TabIndex = 19;
            this.finder_file.TabStop = true;
            this.finder_file.Text = "Arquivo";
            this.finder_file.UseVisualStyleBackColor = true;
            // 
            // finder_fixo
            // 
            this.finder_fixo.AutoSize = true;
            this.finder_fixo.Location = new System.Drawing.Point(380, 12);
            this.finder_fixo.Name = "finder_fixo";
            this.finder_fixo.Size = new System.Drawing.Size(41, 17);
            this.finder_fixo.TabIndex = 20;
            this.finder_fixo.TabStop = true;
            this.finder_fixo.Text = "fixo";
            this.finder_fixo.UseVisualStyleBackColor = true;
            // 
            // principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 512);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tabControl1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de criação de Updates";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
            this.Load += new System.EventHandler(this.LForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menu_options.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.ProgressBar Progress;
        private System.Windows.Forms.Button saveButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog Openfileadd;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip menu_options;
        private System.Windows.Forms.ToolStripMenuItem atualizar_list;
        private System.Windows.Forms.ToolStripMenuItem carregar_list;
        private System.Windows.Forms.ToolStripMenuItem arquivo_context;
        private System.Windows.Forms.ToolStripMenuItem arquivo_context_add_menu;
        private System.Windows.Forms.ToolStripMenuItem removearquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clear_list;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem desenvolvidoPorRobertinhonetToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.RichTextBox log_list;
        public System.Windows.Forms.ToolStripMenuItem license_text_show;
        private System.Windows.Forms.ToolStripMenuItem recalcularToolStripMenuItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mod;
        private System.Windows.Forms.DataGridViewTextBoxColumn CRC_MOD;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button_finder;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.RadioButton finder_file;
        private System.Windows.Forms.RadioButton finder_directory;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton finder_fixo;
    }
}

