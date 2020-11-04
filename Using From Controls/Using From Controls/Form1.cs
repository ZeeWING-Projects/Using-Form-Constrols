using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Using_From_Controls
{
    //
    public partial class Form1 : Form
    {
        public ArrayList peronsList;
        internal delegate void AddToList(PersonDetails person, int index);
        internal AddToList addToListWith_Name;
        internal AddToList addToListWith_Name_Gender;
        internal AddToList addToListWith_Name_Gender_Catagories;

        public Form1()
        {
            InitializeComponent();
            peronsList = new ArrayList();
            addToListWith_Name = new AddToList(AddToList_Name);
            addToListWith_Name_Gender = new AddToList(AddToList_Name_Gender);
            addToListWith_Name_Gender_Catagories = new AddToList(AddToList_Name_Gender_Catagory);
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddToList_Name(PersonDetails person,int index)
        {
            listBox.Items.Add(index + " :  Name :" + person.name );

        }
        private void AddToList_Name_Gender(PersonDetails person, int index)
        {
            listBox.Items.Add(index + " :  Name :" + person.name + " Gender : " + person.gender);

        }
        private void AddToList_Name_Gender_Catagory(PersonDetails person, int index)
        {
            listBox.Items.Add(index + " :  Name :" + person.name + " | Catagory :" + person.catagory + " Gender : " + person.gender);

        }

        private void setObjectsToList(AddToList addToList)
        {
            listBox.Items.Clear();
            int index = 1;
            foreach (PersonDetails person in peronsList)
            {
                Console.WriteLine("Inseting "+person.name);
                addToList(person, index);
                index++;
            }

            lblNumberOFEntries.Text = "" + peronsList.Count;
        }

        private void rbSingleSelection_CheckedChanged(object sender, EventArgs e)
        {
            listBox.SelectionMode = SelectionMode.One;
        }

        private void rbMultiSelection_CheckedChanged(object sender, EventArgs e)
        {
            listBox.SelectionMode = SelectionMode.MultiExtended;
        }

        private void rbMultiSimple_CheckedChanged(object sender, EventArgs e)
        {
            listBox.SelectionMode = SelectionMode.MultiSimple;
        }

        private void rbNone_CheckedChanged(object sender, EventArgs e)
        {
            listBox.SelectionMode = SelectionMode.None;
        }
        private void selectedItem(object sender, EventArgs e)
        {
            int index = 0;
            PersonDetails person1=null;
            foreach (PersonDetails person in peronsList)
            {
                if (index == listBox.SelectedIndex)
                {
                    person1 = person;
                    break;
                }
                index++;
            }
            DisplayProfile displayProfile = new DisplayProfile(person1);
            displayProfile.ShowDialog();

        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            string selection = cbSortingChoice.SelectedItem as string;
            switch (selection)
            {
                case "Show Name":

                    setObjectsToList(addToListWith_Name);

                    break;
                case "Show Name+Gender":

                    setObjectsToList(addToListWith_Name_Gender);

                    break;
                case "Show All":

                    setObjectsToList(addToListWith_Name_Gender_Catagories);

                    break;
                default:

                    setObjectsToList(addToListWith_Name_Gender_Catagories);

                    break;

            }
        }

    }  
}
