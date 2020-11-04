using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Using_From_Controls
{
    public partial class GetUserDataWindow : Form
    {
        internal PersonDetails Person { get; set; }
        string name { get; set; }
        string catagory { get; set; }
        string gender { get; set; }
        ArrayList profiles;
        public GetUserDataWindow()
        {
            InitializeComponent();
            profiles = new ArrayList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            

            name = txtName.Text;
            catagory = cbCatagories.SelectedItem as string;
            if (rbMale.Checked) gender = "Male";
            else if (rbFemale.Checked) gender = "Female";
            else gender = "Not selected";
            if (profiles.Count == 0) profiles.Add("No profile choosed");

            Person= new PersonDetails(name, catagory, gender, profiles);

            this.Hide();
            

        }

        private void btnImportProfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = "F:\\";
            string filter = " Text Files | *.txt;*.docx";
            fileDialog.Filter = filter;
            fileDialog.Multiselect = !(rbSingle.Checked);
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (String name in fileDialog.FileNames)
                {
                    profiles.Add(name);
                }

                label4.Text = "Files: " + profiles.Count;
            }
            else
            {
                
            }
        }
    }
}
