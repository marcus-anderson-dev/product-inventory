/*
 * ModifyPartForm.cs
 * Description: Selects a Part from the Parts table to modify 
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
    public partial class ModifyPartForm : Form
    {
        private Part partToModify;

        //Opens the Modify Part Form
        public ModifyPartForm(Part part)
        {
            InitializeComponent();
            partToModify = part;

            //Converts the Part information to strings
            txtPartID.Text = partToModify.PartID.ToString();
            txtPartName.Text = partToModify.Name;
            txtPartInventory.Text = partToModify.InStock.ToString();
            txtPartPrice.Text = partToModify.Price.ToString();
            txtPartMax.Text = partToModify.Max.ToString();
            txtPartMin.Text = partToModify.Min.ToString();

            //Logic for Subclasses of Part
            if (partToModify is Inhouse)
            {
                rbInHouse.Checked = true;
                lblPartDynamic.Text = "Machine ID";
                txtPartDynamic.Text = ((Inhouse)part).MachineID.ToString();
            }
            else if (partToModify is Outsourced)
            {
                rbOutsourced.Checked = true;
                lblPartDynamic.Text = "Company Name";
                txtPartDynamic.Text = ((Outsourced)part).CompanyName;
            }

            UpdateSaveButton();
        }


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

        //Logic for Saving a part after its modified
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


            if (string.IsNullOrWhiteSpace(txtPartName.Text))
                errors.Add("Name cannot be empty");


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

            if (minValid && maxValid && min > max)
                errors.Add("Min must be less than or equal to Max");

            if (inventoryValid && minValid && maxValid && (inStock < min || inStock > max))
                errors.Add("Inventory must be between Min and Max");


            if (errors.Count > 0)
            {
                MessageBox.Show(string.Join("\n", errors), "Validation Errors");
                return;
            }


            int partID;
            int.TryParse(txtPartID.Text, out partID);

            if (rbInHouse.Checked)
            {
                Inhouse p = new Inhouse();
                p.PartID = partID;
                p.Name = txtPartName.Text;
                p.Price = price;
                p.InStock = inStock;
                p.Max = max;
                p.Min = min;
                p.MachineID = machineID;

                Inventory.UpdatePart(partID, p);
            }
            else
            {
                Outsourced p = new Outsourced();
                p.PartID = partID;
                p.Name = txtPartName.Text;
                p.Price = price;
                p.InStock = inStock;
                p.Max = max;
                p.Min = min;
                p.CompanyName = txtPartDynamic.Text;

                Inventory.UpdatePart(partID, p);
            }

            this.Close();
        }

        //Cancels a Part from being modified without saving
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPartName_TextChanged(object sender, EventArgs e)
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

        private void ValidateField(TextBox box, bool isValid)
        {
            box.BackColor = isValid ? System.Drawing.Color.White : System.Drawing.Color.MistyRose;
        }

        private void UpdateSaveButton()
        {
            btnSave.Enabled = IsFormValid();
        }
    }
}
