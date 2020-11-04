using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Using_From_Controls
{
    public partial class Form1
    {
        internal PersonDetails person;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            GetUserDataWindow userDataWindow = new GetUserDataWindow();
            userDataWindow.ShowDialog();
            person = userDataWindow.Person;
            peronsList.Add(person);
            setObjectsToList(addToListWith_Name_Gender_Catagories);
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
           
        }

        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            ListBox.SelectedIndexCollection value = listBox.SelectedIndices;
            int i = 0;
            foreach (int num in value)
            {
                if (i == 0)
                {
                    peronsList.RemoveAt(num);
                }
                else
                {
                    int v = num;
                    v = v - 1;
                    peronsList.RemoveAt(v);
                }
                i++;
            }
            setObjectsToList(addToListWith_Name_Gender_Catagories);
        }

    }

}

