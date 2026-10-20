# Product Inventory Management System

# Built as a Software 1 Project for WGU

A Windows desktop application for inventory management where you can manage parts and the products built from them.

## Application Features

- **Managing Parts** You can add, modify, delete and search parts. There are two different types of parts.
  - **In-House**, These are made internally
  - **Outsourced**, Purchased from a vendor and tracked by adding a company name.
- **Manage products.** The ability to add, update, delete and search for products.
- **Search by Name** partial, case-insensitive or by ID.
- **Input validation** with error messages:
  - Name is a requirement, price and stock values must be numbers.
  - Min must be less than or equal to Max.
  - Inventory needs to be between Min and Max.
  - A product's price can't be less than the total amount of its parts.

## Design

```
InventoryManagementSystem/
├── Classes/
│   ├── Part.cs          Abstract base class: ID, name, price, stock, min, max
│   ├── Inhouse.cs       Part subclass that adds MachineID
│   ├── Outsourced.cs    Part subclass that adds CompanyName
│   ├── Product.cs       Product with its list of associated parts
│   └── Inventory.cs     Static store for all parts and products
├── MainForm.cs          Main screen displays parts and products grids.
├── AddPartForm.cs       Add / modify parts (dialog box)
├── ModifyPartForm..cs
├── AddProductForm.cs    Add / modify product (dialog box)
├── ModifyProductForm.cs
└── Program.cs           Entry point of application
```


- **Data binding.** The grids are bound to `BindingList<T>` collections, When changes are made it shows up immedietly in the UI without a refresh.
- **Inventory class** The static `Inventory` class has all parts and products.  All the forms are able to read and write from it.
- **Data Storage** Data is used with in memory while the app runs and will not save between different sessions.



