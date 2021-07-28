using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepreciationCalculatorP4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void addFormButton_Click(object sender, EventArgs e)
        {
            DepreciationStraightLine inventory = BuildInventory();
            string summary = inventory.ToString();
        }

        private void BuildInventory()
        {
            DepreciationStraightLine inventory = new DepreciationStraightLine();

            inventory.Title = (titleTextBox.Text);

        }

        private void removeSelectedItemButton_Click(object sender, EventArgs e)
        {
            inventoryTabListBox.SelectedItem = " ";  
                
        }

        private void inventoryTabListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox.Items.Add(inventoryTabListBox.Text);
        }
    }
}
