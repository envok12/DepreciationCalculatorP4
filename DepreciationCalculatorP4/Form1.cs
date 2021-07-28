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
        DepreciationStraightLine inventory = new DepreciationStraightLine();
        private void addFormButton_Click(object sender, EventArgs e)
        {
            DepreciationStraightLine inventory = BuildInventory();
            string summary = inventory.ToString();
        }

        private string BuildInventory()
        {
            

            inventory.Title = (titleTextBox.Text);
            
           
            
            return ToString();
        }

        private void removeSelectedItemButton_Click(object sender, EventArgs e)
        {
            inventoryTabListBox.SelectedItem = " ";  
                
        }

        private void inventoryTabListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> inventoryItems = new List<string>();
            inventoryItems.Add(inventoryTabListBox.Text);
        }

        private void calculateInventoryButton_Click(object sender, EventArgs e)
        {
            //Call calc depending on which radio button is selected and output summary
            if(straightLineRadioButton.Checked)
            {
                inventory.Calc();
            }
            else
            {
                DepreciationDoubleDeclining.Calc();
            }
            summaryTextBox.Visible = true;
            summaryTextBox.Text = ToString();

        }
    }
}
