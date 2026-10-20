/*
 * Outsourced.cs
 * Description: Subclass of Part
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Classes
{
    public class Outsourced : Part
    {
        //CompanyName is the company name of the vendor
        public string CompanyName { get; set; }
    }
}
