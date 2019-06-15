using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

/*CREATED BY: ANDREW PIMPO
 * This program is useful for keeping records of the fellowship members. As can be seen, I avoided a fifth field "weapon,"
 * but the field would not be difficult to add.
 * 
 * fMember.cs is the class used to generate each person.
     */
namespace Pimpo_FellowshipEntry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        StreamReader inputFile;
        StreamWriter outputFile;
        List<fMember> Fellowship = new List<fMember>();
        
        private int _racePass;
        private string _countryPass;
        private string _namePass;
        private string _titlePass;
        private string _weaponPass;
        private string _Race;

        public int RacePass
        {
            get
            {
                return _racePass;
            }

            set
            {
                _racePass = value;
            }
        }

        public string CountryPass
        {
            get
            {
                return _countryPass;
            }

            set
            {
                _countryPass = value;
            }
        }

        public string NamePass
        {
            get
            {
                return _namePass;
            }

            set
            {
                _namePass = value;
            }
        }

        public string TitlePass
        {
            get
            {
                return _titlePass;
            }

            set
            {
                _titlePass = value;
            }
        }

        public string WeaponPass
        {
            get
            {
                return _weaponPass;
            }

            set
            {
                _weaponPass = value;
            }
        }

        public string Race
        {
            get
            {
                return _Race;
            }

            set
            {
                _Race = value;
            }
        }
        private void setRace(int raceID)
        {
            if (raceID == 0)
            {
                Race = "Man";
            }
            else if (raceID == 1)
            {
                Race = "Elf";
            }
            else if (raceID == 2)
            {
                Race = "Dwarf";
            }
            else if (raceID == 3)
            {
                Race = "Halfling";
            }
            else if (raceID == 4)
            {
                Race = "Wizard";
            }
            else
            {
                Race = "Wildman of Dunland";
            }
        }

        //Method to retrieve data
        private void getFMemberData(fMember newMember)
        {
            //Set attributes to passable data
            newMember.Race = Race;
            newMember.Country = CountryPass;
            newMember.Name = NamePass;
            newMember.Title = TitlePass;
            newMember.Weapon = WeaponPass;
        }
        
        //Add a new member
        private void btn_Add_Click(object sender, EventArgs e)
        {
            //Call class for fellowship member
            fMember newMember = new fMember();

            //Call subform to reveal
            addMem add_Window = new addMem(this);
            add_Window.ShowDialog();

            //Check if all fields are ready to receive
            if (!((CountryPass == null) && (NamePass == null) && (TitlePass == null)))
            {
                //Set Race string with Combo Box selected index
                setRace(RacePass);

                //Set Attributes...
                getFMemberData(newMember);

                //ADD member to fellowship
                Fellowship.Add(newMember);

                //Add to the listbox
                lbx_Members.Items.Add(newMember.Race + " - " + newMember.Name + " " + newMember.Title);
            }
            reset();
        }

        //Display extra data
        private void lbx_Members_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbx_Savelist.Items.Clear();
            int index = lbx_Members.SelectedIndex;

            //Display info
            MessageBox.Show("This champion hails from " + Fellowship[index].Country + ".");

            //Open in Savelist
            lbx_Savelist.Items.Add("Name: " + Fellowship[index].Name);
            lbx_Savelist.Items.Add("Race: " + Fellowship[index].Race);
            lbx_Savelist.Items.Add("Origin: " + Fellowship[index].Country);
            lbx_Savelist.Items.Add("Title: " + Fellowship[index].Title);
        }

        //Exit program
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        //Edit an entry
        private void btn_EditMem_Click(object sender, EventArgs e)
        {
            //Retrieve index of desired editing
            int index = lbx_Members.SelectedIndex;
            int raceID;

            //Create new PlaceHolder
            fMember pHolder = new fMember();

            //Set placeholder member info to the same
            if(index < 0)
            {
                MessageBox.Show("Please select a member to Edit");
                return;
            }
            raceID = setCbxIndex(Fellowship[index].Race);
            RacePass = raceID;
            CountryPass = Fellowship[index].Country;
            NamePass = Fellowship[index].Name;
            TitlePass = Fellowship[index].Title;
            WeaponPass = Fellowship[index].Weapon;

            //Call subform to reveal
            addMem add_Window = new addMem(this);
            add_Window.PopulateFields();
            add_Window.ShowDialog();
            // -----------------
            if (!((CountryPass == null) && (NamePass == null) && (TitlePass == null)))
            {
                //Set Race string with Combo Box selected index
                setRace(RacePass);

                //Set Attributes...
                getFMemberData(pHolder);

                //Replace old values
                Fellowship[index] = pHolder;

                //Replace in ListBox
                lbx_Members.Items.Clear();
                int i = 0;
                while(i < Fellowship.Count)
                {
                    lbx_Members.Items.Insert(i, Fellowship[i].Race + " - " + Fellowship[i].Name + " " + Fellowship[i].Title);
                    i++;
                }
                
            }
            //Toggle focus
            btn_Add.Focus();

            //Set passing vars to null or zero
            Race = null;
            RacePass = 0;
            CountryPass = null;
            NamePass = null;
            TitlePass = null;
            WeaponPass = null;
        }
        
        //Set the race to the proper combo box index
        public int setCbxIndex(string Race)
        {
            int raceID;
            if (Race == "Man")
            {
                raceID = 0;
            }
            else if (Race == "Elf")
            {
               raceID = 1 ;
            }
            else if (Race == "Dwarf")
            {
                raceID = 2;
            }
            else if (Race == "Halfling")
            {
                raceID = 3;
            }
            else if (Race == "Wizard")
            {
               raceID = 4;
            }
            else
            {
                raceID = 5;
            }
            return raceID;
        }

        //Load a file that contains the right info
        private void btn_Load_Click(object sender, EventArgs e)
        {
            //Open dialog
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                inputFile = File.OpenText(openFileDialog1.FileName);

                MessageBox.Show("File Read Successfully!");
            }
            else MessageBox.Show("File Open error");

            //Create new member and error title
            String error = null;

            string line;
            int x = 0;

            while ((line = inputFile.ReadLine()) != null)
            {
                fMember loadMember = new fMember();
                //MessageBox.Show(line);
                try
                {
                    Race = line.Split(',')[0];
                    CountryPass = line.Split(',')[1];
                    NamePass = line.Split(',')[2];
                    TitlePass = line.Split(',')[3];
                    RacePass = Convert.ToInt32(line.Split(',')[4]);
                }
                catch (Exception ex)
                {
                    error = "Improper data";
                    MessageBox.Show(ex.Message);
                }

                if (error == null)
                {
                    //Collect Race
                    setRace(RacePass);

                    //Set Attributes...
                    getFMemberData(loadMember);

                    //Add member...
                    Fellowship.Add(loadMember);
                }
            }
            for(int i = 0; i < Fellowship.Count; i++)
            {
                lbx_Members.Items.Add(Fellowship[i].Race + " - " + Fellowship[i].Name + " " + Fellowship[i].Title);
            }
            reset();
        }

        //Save the current members to a file
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                outputFile = File.CreateText(saveFileDialog1.FileName);
                string[] OUTPUT = createOutputString(Fellowship);
                for(int i = 0; i<OUTPUT.Length; i++)
                {
                    outputFile.WriteLine(OUTPUT[i]);
                }
                outputFile.Close();
                MessageBox.Show("File saved");
            }
            else
            {
                MessageBox.Show("File save error!");
            }
        }

        //Creates the necessary ouput list for reading into the file
        private string[] createOutputString(List<fMember> Fellowship)
        {
            int length = lbx_Members.Items.Count;
            string[] output = new string[length];
            int index = 0;
            foreach(var element in Fellowship)
            {
                string outPut = element.Race + "," + element.Country + "," + element.Name + "," + element.Title + "," + setCbxIndex(element.Race);
                output[index] = outPut;
                index++;
                lbx_Savelist.Items.Add(outPut);
            }
            return output;
        }

        //Resets the fields for passing new info
        private void reset()
        {
            //Toggle focus
            btn_Add.Focus();

            //Set passing vars to null or zero
            Race = null;
            RacePass = 0;
            CountryPass = null;
            NamePass = null;
            TitlePass = null;
            WeaponPass = null;
        }
    }

}
