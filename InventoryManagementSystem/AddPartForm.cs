/*
 * addPartForm.cs
 * Description: Subclass for Parts
 */

using InventoryManagementSystem.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class addPartForm : Form
    {
        public addPartForm()
        {
            InitializeComponent();
            UpdateSaveButton();
        }

        //Radio button if statement
        private void rbInHouse_CheckedChanged(object sender, EventArgs e)

        {
            if (rbInHouse.Checked)
            {
                lblPartDynamic.Text = "Machine ID";
            }
            else
            {
                lblPartDynamic.Text = "Company Name";
            }
            txtPartDynamic_TextChanged(sender, e);
        }

        //This is the Save button when adding a part - Contains Part Logic
        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> errors = new List<string>();

            int inStock;
            bool inventoryValid = int.TryParse(txtPartInventory.Text, out inStock);
            if (!inventoryValid) errors.Add("Inventory must be a whole number");

            decimal price;
            bool priceValid = decimal.TryParse(txtPartPrice.Text, out price);
            if (!priceValid) errors.Add("Price must be a number");

            int max;
            bool maxValid = int.TryParse(txtPartMax.Text, out max);
            if (!maxValid) errors.Add("Max must be a whole number");

            int min;
            bool minValid = int.TryParse(txtPartMin.Text, out min);
            if (!minValid) errors.Add("Min must be a whole number");

            int machineID = 0;
            if (rbInHouse.Checked)
            {
                if (!int.TryParse(txtPartDynamic.Text, out machineID))
                    errors.Add("Machine ID must be a whole number");
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtPartDynamic.Text))
                    errors.Add("Company Name cannot be empty");
            }

            if (string.IsNullOrWhiteSpace(txtPartName.Text))
                errors.Add("Name cannot be empty");

            if (minValid && maxValid && min > max)
                errors.Add("Min must be less than or equal to Max");

            if (inventoryValid && minValid && maxValid && (inStock < min || inStock > max))
                errors.Add("Inventory must be between Min and Max");

            if (errors.Count > 0)
            {
                MessageBox.Show(String.Join("\n", errors), "Validation Errors");
                return;
            }


            int newID = 1;
            foreach (Part part in Inventory.AllParts)
            {
                if (part.PartID >= newID)
                    newID= part.PartID + 1;
            }

            if (rbInHouse.Checked)
            {


                Inhouse p = new Inhouse();
                p.PartID = newID;
                p.Name = txtPartName.Text;
                p.Price = price;
                p.InStock = inStock;
                p.Max = max;
                p.Min = min;
                p.MachineID = machineID;

                Inventory.AllParts.Add(p);
            }
            else
            {

                Outsourced p = new Outsourced();
                p.PartID = newID;
                p.Name = txtPartName.Text;
                p.Price = price;
                p.InStock = inStock;
                p.Max = max;
                p.Min = min;
                p.CompanyName = txtPartDynamic.Text;

                Inventory.AllParts.Add(p);
            }
            this.Close();

        }

        //Cancel button closes addPart form without saving
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void txtPartName_TextChanged_1(object sender, EventArgs e)
        {
            ValidateField(txtPartName, !string.IsNullOrWhiteSpace(txtPartName.Text));
            UpdateSaveButton();
        }

        private void txtPartInventory_TextChanged(object sender, EventArgs e)
        {
            bool invParsed = int.TryParse(txtPartInventory.Text, out int inv);
            bool minParsed = int.TryParse(txtPartMin.Text, out int min);
            bool maxParsed = int.TryParse(txtPartMax.Text, out int max);

            bool valid = invParsed;

            if (invParsed && minParsed && maxParsed)
            {
                valid = inv >= min && inv <= max;
            }
            ValidateField(txtPartInventory, valid);
            UpdateSaveButton();
        }

        private void txtPartPrice_TextChanged(object sender, EventArgs e)
        {
            ValidateField(txtPartPrice, decimal.TryParse(txtPartPrice.Text, out _));
            UpdateSaveButton();
        }

        private void txtPartMax_TextChanged(object sender, EventArgs e)
        {
            ValidateMinMax();
            txtPartInventory_TextChanged(sender, e);
            UpdateSaveButton();
        }

        private void txtPartMin_TextChanged(object sender, EventArgs e)
        {
            ValidateMinMax();
            txtPartInventory_TextChanged(sender, e);
            UpdateSaveButton();
        }

        private void txtPartDynamic_TextChanged(object sender, EventArgs e)
        {
            bool valid;
            if (rbInHouse.Checked)
                valid = int.TryParse(txtPartDynamic.Text, out _);
            else
                valid = !string.IsNullOrWhiteSpace(txtPartDynamic.Text);

            ValidateField(txtPartDynamic, valid);
            UpdateSaveButton();
        }

        private void ValidateMinMax()
        {
            bool minParsed = int.TryParse(txtPartMin.Text, out int min);
            bool maxParsed = int.TryParse(txtPartMax.Text, out int max);

            bool relationOK = !minParsed || !maxParsed || min <= max;

            ValidateField(txtPartMin, minParsed && relationOK);
            ValidateField(txtPartMax, maxParsed && relationOK);
        }

        private bool IsFormValid()
        {
            if (string.IsNullOrWhiteSpace(txtPartName.Text)) return false;
            if (!int.TryParse(txtPartInventory.Text, out int inv)) return false;
            if (!decimal.TryParse(txtPartPrice.Text, out _)) return false;
            if (!int.TryParse(txtPartMin.Text, out int min)) return false;
            if (!int.TryParse(txtPartMax.Text, out int max)) return false;
            if (min > max) return false;
            if (inv < min || inv > max) return false;

            if (rbInHouse.Checked && !int.TryParse(txtPartDynamic.Text, out _)) return false;
            if (!rbInHouse.Checked && string.IsNullOrWhiteSpace(txtPartDynamic.Text)) return false;

            return true;
        }

        private void UpdateSaveButton()
        {
            btnSave.Enabled = IsFormValid();
        }

        private void ValidateField(TextBox box, bool isValid)
        {
            box.BackColor = isValid ? System.Drawing.Color.White : System.Drawing.Color.MistyRose;
        }
    }
}
