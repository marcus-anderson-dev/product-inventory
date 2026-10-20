/*
 * Inventory.cs
 * Description: Static class that holds Parts and Products
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Classes
{
    //Inventory class with two binding lists so there's one shared inventory over the Inventory Management App
    public static class Inventory
    {
        public static BindingList<Product> Products { get; set; } = new BindingList<Product>();
        public static BindingList<Part> AllParts { get; set; } = new BindingList<Part>();


        //Methods


        //Adds a product to the Products list
        public static void AddProduct(Product product)
        {
            Products.Add(product);
        }

        //Removes a product to the Products list
        public static bool RemoveProduct(int productID)
        {
            foreach (Product p in Products)
            {
                if (p.ProductID == productID)
                {
                    Products.Remove(p);
                    return true;
                }
            }
            return false;
        }

        //Finds product in Products list that matches ProductID
        public static Product LookupProduct(int productID)
        {
            foreach (Product p in Products)
            {
                if (p.ProductID == productID)
                {
                    return p;
                }
            }
            return null;

        }

        //Updates when modifying a Product - Matches product by ID
        public static void UpdateProduct(int productID, Product updateProduct)
        {
            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].ProductID == productID)
                {
                    Products[i] = updateProduct;
                    return;
                }

            } 
        }

        //Adds a part to the AllParts list
        public static void AddPart(Part part)
        {
            AllParts.Add(part);
        }

        //Deletes a Part from teh AllParts list - Matches part by ID
        public static bool DeletePart(int partID)
        {
            foreach (Part p in AllParts)
            {
                if (p.PartID == partID)
                {
                    AllParts.Remove(p);
                    return true;
                }
            }
            return false;
        }

        //Finds a Part in the Allparts list - Matches by PartID
        public static Part LookupPart(int partID)
        {
            foreach (Part p in AllParts)
            {
                if (p.PartID == partID)
                {
                    return p;
                }
            }
            return null;
        }

        //Loops through AllParts to find the part to update
        public static void UpdatePart(int partID, Part part)
        {
            for (int i = 0; i < AllParts.Count; i++)
            {
                if (AllParts[i].PartID == partID)
                {
                    AllParts[i] = part;
                    return;
                }
            }

        }

    }
}