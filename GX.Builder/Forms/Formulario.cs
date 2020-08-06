﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Update.Maker.Source_files;

namespace Update.Maker.Forms
{
    public partial class Formulario : Form
    {
        public Formulario()
        {
            InitializeComponent();
            Globals.formulario = this;
        }

        private void Formulario_Load(object sender, EventArgs e)
        {

        }
        public int CurrentItem { get; set; }
        public void CreateTextBox(int id, string title, string file, string releasenote, string link, string version, string shortversion, string system, string type, string criticalupdate)
        {
            CurrentItem = id;
            file_textbox.Text = file;
            title_textbox.Text = title;
            releasenote_textbox.Text = releasenote;
            link_textbox.Text = link;
            version_textbox.Text = version;
            shortversion_textbox.Text = shortversion;
            system_combobox.Text = system;
            type_textbox.Text = type;
            criticalupdate_textbox.Text = criticalupdate;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dataGridViewRow in Globals.principal.dataGridView1.Rows)
            {

                DataGridViewRow newDataRow = Globals.principal.dataGridView1.Rows[dataGridViewRow.Index];
                if (Convert.ToInt32(newDataRow.Cells[0].Value) == CurrentItem)
                {

                   
                 newDataRow.Cells[2].Value = file_textbox.Text;

                    newDataRow.Cells[1].Value = title_textbox.Text;

                    newDataRow.Cells[3].Value = releasenote_textbox.Text;

                    newDataRow.Cells[4].Value = link_textbox.Text;


                    newDataRow.Cells[5].Value = version_textbox.Text;

                    newDataRow.Cells[6].Value = shortversion_textbox.Text;


                        newDataRow.Cells[7].Value = system_combobox.Text;

                    newDataRow.Cells[8].Value = type_textbox.Text;

                    newDataRow.Cells[9].Value = criticalupdate_textbox;

                    break;
                }

            }
        }

    }
}
