/*
 * addProductForm.cs
 * Description: Subclass for Parts
 */

using InventoryManagementSystem.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class addProductForm : Form
    {

        private BindingList<Part> candidateAssociatedParts = new BindingList<Part>();

        public addProductForm()
        {
            InitializeComponent();
            UpdateSaveButton();
        }

        private void addProductForm_Load(object sender, EventArgs e)
        {
            dgvCandidateParts.DataSource = Inventory.AllParts;
            dgvAssociatedParts.DataSource = candidateAssociatedParts;
        }


        private void btnaddAssociatedPart_Click(object sender, EventArgs e)
        {
            if (dgvCandidateParts.CurrentRow == null) return;

            Part selectedPart = (Part)dgvCandidateParts.CurrentRow.DataBoundItem;
            candidateAssociatedParts.Add(selectedPart);

            txtProductPrice_TextChanged(sender, e);
        }

        private void btnDeleteAssociatedPart_Click(object sender, EventArgs e)
        {
            if (dgvAssociatedParts.CurrentRow == null) return;

            Part selectedPart = (Part)dgvAssociatedParts.CurrentRow.DataBoundItem;
            candidateAssociatedParts.Remove(selectedPart);

            txtProductPrice_TextChanged(sender, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> errors = new List<string>();

            int inventory;
            bool inventoryValid = int.TryParse(txtProductInventory.Text, out inventory);
            if (!inventoryValid) errors.Add("Inventory must be a whole number");

            decimal price;
            bool priceValid = decimal.TryParse(txtProductPrice.Text, out price);
            if (!priceValid) errors.Add("Price must be a number");

            int max;
            bool maxValid = int.TryParse(txtProductMax.Text, out max);
            if (!maxValid) errors.Add("Max must be a whole number");

            int min;
            bool minValid = int.TryParse(txtProductMin.Text, out min);
            if (!minValid) errors.Add("Min must be a whole number");

            if (string.IsNullOrWhiteSpace(txtProductName.Text))
                errors.Add("Name cannot be empty");

            if (minValid && maxValid && min > max)
                errors.Add("Min must be less than or equal to Max");

            if (inventoryValid && minValid && maxValid && (inventory < min || inventory > max))
                errors.Add("Inventory must be between Min and Max");

            decimal partsTotal = 0;
            foreach (Part p in candidateAssociatedParts)
            {
                partsTotal += p.Price;
            }

            if (priceValid && price < partsTotal)
                errors.Add("Product price must be greater than or equal to the sum of associated parts' prices");


            if (errors.Count > 0)
            {
                MessageBox.Show(string.Join("\n", errors), "Validation Errors");
                return;
            }

            int newID = 1;
            foreach (Product prod in Inventory.Products)
            {
                if (prod.ProductID >= newID)
                    newID = prod.ProductID + 1;
            }

            Product newProduct = new Product();
            newProduct.ProductID = newID;
            newProduct.Name = txtProductName.Text;
            newProduct.Price = price;
            newProduct.InStock = inventory;
            newProduct.Max = max;
            newProduct.Min = min;

            foreach (Part part in candidateAssociatedParts)
            {
                newProduct.AddAssociatedPart(part);
            }

            Inventory.AddProduct(newProduct);
            this.Close();
        }

        private void btnCandidatePartSearch_Click(object sender, EventArgs e)
        {
            string query = txtCandidatePartSearch.Text.Trim();

            if (string.IsNullOrWhiteSpace(query))
            {
                dgvCandidateParts.DataSource = Inventory.AllParts;
                return;
            }

            BindingList<Part> results = new BindingList<Part>();

            foreach (Part p in Inventory.AllParts)
            {
                if (p.Name != null && p.Name.ToLower().Contains(query.ToLower()))
                    results.Add(p);
                else if (int.TryParse(query, out int id) && p.PartID == id)
                    results.Add(p);
            }

            if (results.Count == 0)
            {
                MessageBox.Show("No parts found.", "Search");
                return;
            }

            dgvCandidateParts.DataSource = results;
        }


        private void txtProductName_TextChanged(object sender, EventArgs e)
        {
            ValidateField(txtProductName, !string.IsNullOrWhiteSpace(txtProductName.Text));
            UpdateSaveButton();
        }

        private void txtProductInventory_TextChanged(object sender, EventArgs e)
        {
            bool invParsed = int.TryParse(txtProductInventory.Text, out int inv);
            bool minParsed = int.TryParse(txtProductMin.Text, out int min);
            bool maxParsed = int.TryParse(txtProductMax.Text, out int max);

            bool valid = invParsed;

            if (invParsed && minParsed && maxParsed)
            {
                valid = inv >= min && inv <= max;
            }
            ValidateField(txtProductInventory, valid);
            UpdateSaveButton();
        }


        private void txtProductPrice_TextChanged(object sender, EventArgs e)
        {
            bool priceParsed = decimal.TryParse(txtProductPrice.Text, out decimal price);

            decimal partsTotal = 0;
            foreach (Part p in candidateAssociatedParts)
            {
                partsTotal += p.Price;
            }

            bool valid = priceParsed && price >= partsTotal;

            ValidateField(txtProductPrice, valid);
            UpdateSaveButton();
        }
        

        private void txtProductMax_TextChanged(object sender, EventArgs e)
        {
            ValidateMinMax();
            txtProductInventory_TextChanged(sender, e);
            UpdateSaveButton();
        }

        private void txtProductMin_TextChanged(object sender, EventArgs e)
        {
            ValidateMinMax();
            txtProductInventory_TextChanged(sender, e);
            UpdateSaveButton();
        }


        private void ValidateMinMax()
        {
            bool minParsed = int.TryParse(txtProductMin.Text, out int min);
            bool maxParsed = int.TryParse(txtProductMax.Text, out int max);

            bool relationOK = !minParsed || !maxParsed || min <= max;

            ValidateField(txtProductMin, minParsed && relationOK);
            ValidateField(txtProductMax, maxParsed && relationOK);
        }

        private bool IsFormValid()
        {
            if (string.IsNullOrWhiteSpace(txtProductName.Text)) return false;
            if (!int.TryParse(txtProductInventory.Text, out int inv)) return false;
            if (!decimal.TryParse(txtProductPrice.Text, out decimal price)) return false;
            if (!int.TryParse(txtProductMin.Text, out int min)) return false;
            if (!int.TryParse(txtProductMax.Text, out int max)) return false;
            if (min > max) return false;
            if (inv < min || inv > max) return false;

            decimal partsTotal = 0;
            foreach (Part p in candidateAssociatedParts)
            {
                partsTotal += p.Price;
            }

            if (price < partsTotal) return false;

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
