/*
 * Inhouse.cs
 * Description: Subclass for Parts
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Classes
{
    public class Inhouse : Part
    {
        //Identifier
        public int MachineID { get; set; }
    }
}
