/*
 * Product.cs
 * Description: Product class defines a product made up of parts.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Classes
{
    //Represents a product in the inventory
    public class Product
    {
        //Associated parts list that updates on add/delete/modify
        public BindingList<Part> AssociatedParts { get; set; } = new BindingList<Part>();
        
        //Unique Identifier for a Product
        public int ProductID { get; set; }

        //Name of a Product
        public string Name { get; set; }

        //Price of a Product
        public decimal Price { get; set; }

        //Current Quantity on hand
        public int InStock { get; set; }

        //Minimum amount of inventory
        public int Min { get; set; }

        //Maximum amount of inventory
        public int Max { get; set; }


        //Methods


        //Adds a Part to the AssociatedParts list
        public void AddAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }

        //Removes a Part to the AssociatedParts list
        public bool RemoveAssociatedPart(int partID)
        {
            foreach (Part p in AssociatedParts)
            {
                if (p.PartID == partID)
                {
                    AssociatedParts.Remove(p);
                    return true;
                }
            }
            return false;
        }

        //Finds a Part in AssociatedParts list - Matches PartID
        public Part LookupAssociatedPart(int partID)
        {
            foreach(Part p in AssociatedParts)
            {
                if (p.PartID == partID)
                {
                    return p;
                }      
            }
            return null;
        }
    }
}
