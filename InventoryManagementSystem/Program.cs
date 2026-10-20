/*
 * Program.cs
 * Description: Runs app on startup and launches MainForm
 */

using System;
using System.Windows.Forms;


namespace InventoryManagementSystem
{
    internal class Program
    {
        [STAThread]
        static void Main()
        {
            //Opens MainForm
            Application.Run(new MainForm());
        }
    }
}
