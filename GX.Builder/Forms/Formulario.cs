using System;
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
        public void CreateTextBox(Items item)
        {
            CurrentItem = item.Id;
            file_textbox.Text = item.File;
            title_textbox.Text = item.Title ;
            releasenote_textbox.Text = item.Releasenote;
            link_textbox.Text = item.Link;
            version_textbox.Text = item.Version;
            shortversion_textbox.Text = item.Shortversion ;
            system_combobox.Text = item.System;
            type_textbox.Text = item.System;
            criticalupdate_textbox.Text = item.Criticalupdate;

            changelogfile_textbox.Text = item.Changelogpath;
            changelog_url_textbox.Text = item.Changelogurl;
            PrefixVersion_checkbox.Checked = item.Isprefixed;
           

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

                    newDataRow.Cells[9].Value = criticalupdate_textbox.Text;
                    newDataRow.Cells[10].Value = changelogfile_textbox.Text;
                    newDataRow.Cells[11].Value = criticalupdate_textbox.Text;
                    newDataRow.Cells[12].Value = PrefixVersion_checkbox.Enabled;
                    break;
                }

            }
        }

    }
}

