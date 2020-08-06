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
            this.listarPastaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.finder_fixo = new System.Windows.Forms.RadioButton();
            this.finder_file = new System.Windows.Forms.RadioButton();
            this.finder_directory = new System.Windows.Forms.RadioButton();
            this.button_finder = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menu_options.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            this.menu_options.Size = new System.Drawing.Size(203, 136);
            this.menu_options.Opening += new System.ComponentModel.CancelEventHandler(this.Menu_options_Opening);
            // 
            // atualizar_list
            // 
            this.atualizar_list.Name = "atualizar_list";
            this.atualizar_list.Size = new System.Drawing.Size(202, 22);
            this.atualizar_list.Text = "Atualizar lista";
            this.atualizar_list.Click += new System.EventHandler(this.Atualizar_list_Click);
            // 
            // carregar_list
            // 
            this.carregar_list.Name = "carregar_list";
            this.carregar_list.Size = new System.Drawing.Size(202, 22);
            this.carregar_list.Text = "Carregar lista";
            this.carregar_list.Click += new System.EventHandler(this.Carregar_list_Click);
            // 
            // arquivo_context
            // 
            this.arquivo_context.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.arquivo_context.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivo_context_add_menu,
            this.removearquivoToolStripMenuItem,
            this.listarPastaToolStripMenuItem});
            this.arquivo_context.ForeColor = System.Drawing.Color.White;
            this.arquivo_context.Name = "arquivo_context";
            this.arquivo_context.Size = new System.Drawing.Size(202, 22);
            this.arquivo_context.Text = "Arquivo";
            // 
            // arquivo_context_add_menu
            // 
            this.arquivo_context_add_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.arquivo_context_add_menu.Name = "arquivo_context_add_menu";
            this.arquivo_context_add_menu.Size = new System.Drawing.Size(168, 22);
            this.arquivo_context_add_menu.Text = "Adicionar arquivo";
            this.arquivo_context_add_menu.Click += new System.EventHandler(this.Arquivo_context_add_menu_Click);
            // 
            // removearquivoToolStripMenuItem
            // 
            this.removearquivoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.removearquivoToolStripMenuItem.Name = "removearquivoToolStripMenuItem";
            this.removearquivoToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.removearquivoToolStripMenuItem.Text = "Remover arquivo";
            this.removearquivoToolStripMenuItem.Click += new System.EventHandler(this.RemovearquivoToolStripMenuItem_Click);
            // 
            // listarPastaToolStripMenuItem
            // 
            this.listarPastaToolStripMenuItem.Name = "listarPastaToolStripMenuItem";
            this.listarPastaToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.listarPastaToolStripMenuItem.Text = "Listar pasta";
            this.listarPastaToolStripMenuItem.Click += new System.EventHandler(this.ListarPastaToolStripMenuItem_Click);
            // 
            // clear_list
            // 
            this.clear_list.BackColor = System.Drawing.Color.Red;
            this.clear_list.ForeColor = System.Drawing.Color.White;
            this.clear_list.Name = "clear_list";
            this.clear_list.Size = new System.Drawing.Size(202, 22);
            this.clear_list.Text = "Limpar lista";
            this.clear_list.Click += new System.EventHandler(this.LimparListaToolStripMenuItem_Click);
            // 
            // recalcularToolStripMenuItem
            // 
            this.recalcularToolStripMenuItem.Name = "recalcularToolStripMenuItem";
            this.recalcularToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
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
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(883, 512);
            this.tabControl1.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.textBox1);
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
            this.tabPage1.Size = new System.Drawing.Size(875, 486);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Principal";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.TabPage1_Click);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(875, 486);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Launcher";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(239, 300);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(230, 20);
            this.textBox1.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(198, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "label6";
            // 
            // principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
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
        public System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.RichTextBox log_list;
        public System.Windows.Forms.ToolStripMenuItem license_text_show;
        private System.Windows.Forms.ToolStripMenuItem recalcularToolStripMenuItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button_finder;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.RadioButton finder_file;
        private System.Windows.Forms.RadioButton finder_directory;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton finder_fixo;
        private System.Windows.Forms.ToolStripMenuItem listarPastaToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
    }
}

