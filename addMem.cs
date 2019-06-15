using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pimpo_FellowshipEntry
{
    public partial class addMem : Form
    {
        public addMem()
        {
            InitializeComponent();
        }
        private Form1 mainform = null;
        public addMem(Form callingForm)
        {
            InitializeComponent();
            mainform = callingForm as Form1;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            //Pass data
            this.mainform.RacePass = cbx_Race.SelectedIndex;
            this.mainform.CountryPass = txt_Country.Text;
            this.mainform.NamePass = txt_Name.Text;
            this.mainform.TitlePass = txt_Title.Text;

            //Clear boxes
            cbx_Race.SelectedIndex = 0;
            txt_Country.Text = null;
            txt_Name.Text = null;
            txt_Title.Text = null;

            //Close form
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            //Cancel any adding done
            this.mainform.RacePass = 0;
            this.mainform.CountryPass = null;
            this.mainform.NamePass = null;
            this.mainform.TitlePass = null;

            //Clear boxes
            cbx_Race.SelectedIndex = 0;
            txt_Country.Text = null;
            txt_Name.Text = null;
            txt_Title.Text = null;

            //Close form
            this.Close();
        }
        public void PopulateFields()
        {
            //Populate fields as shown while editing
            cbx_Race.SelectedIndex = this.mainform.RacePass;
            txt_Country.Text = this.mainform.CountryPass;
            txt_Name.Text = this.mainform.NamePass;
            txt_Title.Text = this.mainform.TitlePass;
        }
    }
}
