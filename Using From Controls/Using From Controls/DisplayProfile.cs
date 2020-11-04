using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Using_From_Controls
{
    public partial class DisplayProfile : Form
    {
        PersonDetails person;
        internal DisplayProfile(PersonDetails person)
        {
            InitializeComponent();
            this.person = person;
        }

        private void DisplayProfile_Load(object sender, EventArgs e)
        {
            lblName.Text = "Name :"+person.name;
            lblCatagory.Text = "Catagory :" + person.catagory;
            lblGender.Text = "Gender :" + person.gender;
            foreach (String file in person.profiles)
            {
                listBox.Items.Add(file);
            }
        }
        private void openFile(object sender, EventArgs e)
        {
            string file = listBox.SelectedItem as string;
            var fileToOpen = file;
            var process = new Process();
            process.StartInfo = new ProcessStartInfo()
            {
                UseShellExecute = true,
                FileName = fileToOpen
            };

            process.Start();
            process.WaitForExit();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
