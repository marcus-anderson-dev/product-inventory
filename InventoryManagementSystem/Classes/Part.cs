/*
 * Part.cs
 * Description: Abstract class that defines all parts in Inventory
 */

namespace InventoryManagementSystem.Classes
{
    public abstract class Part
    {
        //Unique Identifier for a Part
        public int PartID { get; set; }

        //Gives a Name to a Part
        public string Name { get; set; }

        //Price of a part 
        public decimal Price { get; set; }

        //Current Quantity on hand
        public int InStock { get; set; }

        //Minimum amount of inventory
        public int Min { get; set; }

        //Maximum amount of inventory
        public int Max { get; set; }
    }
}
