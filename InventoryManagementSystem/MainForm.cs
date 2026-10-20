/*
 * MainForm.cs
 * Description: Main UI - Displays Parts and Products with user actions
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryManagementSystem;
using InventoryManagementSystem.Classes;

namespace InventoryManagementSystem
{
    public partial class MainForm : Form
    {        
        public MainForm()
        {
            InitializeComponent();
        }

        //Runs when the form opens and binds both grids to Static Inventory Lists
        private void MainForm_Load(object sender, EventArgs e)
        {
            dgvParts.DataSource = Inventory.AllParts;
            dgvProducts.DataSource = Inventory.Products;
        }

        //Opens the addPart Part Dialog
        private void btnaddPart_Click(object sender, EventArgs e)
        {        
            addPartForm addPartForm = new addPartForm();
            addPartForm.ShowDialog();
        }

        //Opens the Modify Part Dialog
        private void btnModifyPart_Click(object sender, EventArgs e)
        {
            if (dgvParts.CurrentRow == null) return;

            Part selectedPart = (Part)dgvParts.CurrentRow.DataBoundItem;
            ModifyPartForm modifyPartForm = new ModifyPartForm(selectedPart);
            modifyPartForm.ShowDialog();
        }

        //Opens the addProductForm
        private void btnaddProduct_Click(object sender, EventArgs e)
        {
            addProductForm addProductFrom = new addProductForm();
            addProductFrom.ShowDialog();
        }

        //Opens the ModifyProductForm
        private void btnProductPart_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null) return;

            Product selectedProduct = (Product)dgvProducts.CurrentRow.DataBoundItem;
            ModifyProductForm modifyForm = new ModifyProductForm(selectedProduct);
            modifyForm.ShowDialog();
        }

        //Deletes a Part
        private void btndeletePart_Click(object sender, EventArgs e)
        {
            if (dgvParts.CurrentRow == null) return;

            Part selectedPart = (Part)dgvParts.CurrentRow.DataBoundItem;

            // Constraint check — does any product use this part?
            foreach (Product p in Inventory.Products)
            {
                if (p.AssociatedParts.Contains(selectedPart))
                {
                    MessageBox.Show(
                        "Cannot delete a part that is associated with a product. " +
                        "Remove the part from the product before deleting it.",
                        "Cannot Delete",
                        MessageBoxButtons.OK);
                    return;
                }
            }

            // Loop finished without finding the part in any product → safe to confirm
            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this part?",
                "Confirm Delete",
                MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Inventory.DeletePart(selectedPart.PartID);
            }
        }


        //Deletes a Product
        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null) return;

            Product selectedProduct = (Product)dgvProducts.CurrentRow.DataBoundItem;

            if (selectedProduct.AssociatedParts.Count > 0)
            {
                MessageBox.Show(
                    "Cannot delete a product that has associated parts.  Remove the associated parts first.",
                    "Cannot Delete",
                    MessageBoxButtons.OK);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this product?",
                "Confirm Delete",
                MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Inventory.RemoveProduct(selectedProduct.ProductID);
            }
        }


        //Search button for finding a Part
        private void btnPartSearch_Click(object sender, EventArgs e)
        {
            string query = txtPartSearch.Text.Trim();

            if (string.IsNullOrWhiteSpace(query))
            {
                dgvParts.DataSource = Inventory.AllParts;
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

            dgvParts.DataSource = results;
        }

        //Search button for finding a product
        private void btnProductSearch_Click(object sender, EventArgs e)
        {
            string query = txtProductSearch.Text.Trim();

            if (string.IsNullOrWhiteSpace(query))
            {
                dgvProducts.DataSource = Inventory.Products;
                return;
            }

            BindingList<Product> results = new BindingList<Product>();

            foreach (Product p in Inventory.Products)
            {
                if (p.Name != null && p.Name.ToLower().Contains(query.ToLower()))
                    results.Add(p);
                else if (int.TryParse(query, out int id) && p.ProductID == id)
                    results.Add(p);
            }

            if (results.Count == 0)
            {
                MessageBox.Show("No products found.", "Search");
                return;
            }

            dgvProducts.DataSource = results;
        }

        //Exit button - Closes application
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
