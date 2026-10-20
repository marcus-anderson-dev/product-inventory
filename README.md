# Product Inventory Management System

A Windows desktop app for tracking parts and the products built from them. Built in C# with Windows Forms on .NET Framework 4.8.

## Features

- **Manage parts.** Add, modify, delete and search parts. Each part is either:
  - **In-House**, made internally and tracked by a Machine ID, or
  - **Outsourced**, bought from a vendor and tracked by Company Name.
- **Manage products.** Add, modify, delete and search products, and pick which parts each product is made from.
- **Search** by name (partial, case-insensitive) or by exact ID.
- **Input validation** with clear error messages:
  - Name is required, and price and stock values must be numbers.
  - Min must be less than or equal to Max.
  - Inventory must fall between Min and Max.
  - A product's price can't be less than the total price of its parts.
- **Data safety rules**
  - A part can't be deleted while a product still uses it.
  - A product can't be deleted while it still has parts attached.
  - Every delete asks for confirmation.
- **Automatic IDs** for new parts and products.

## Design

```
InventoryManagementSystem/
├── Classes/
│   ├── Part.cs          Abstract base class: ID, name, price, stock, min, max
│   ├── Inhouse.cs       Part subclass that adds MachineID
│   ├── Outsourced.cs    Part subclass that adds CompanyName
│   ├── Product.cs       Product with its list of associated parts
│   └── Inventory.cs     Static store for all parts and products
├── MainForm.cs          Main screen with the parts and products grids
├── AddPartForm.cs       Add / modify part dialogs
├── ModifyPartForm..cs
├── AddProductForm.cs    Add / modify product dialogs
├── ModifyProductForm.cs
└── Program.cs           Entry point
```

Key concepts:

- **Inheritance and polymorphism.** `Part` is abstract. `Inhouse` and `Outsourced` extend it, so both kinds of part live in one list.
- **Data binding.** The grids are bound to `BindingList<T>` collections, so changes show up in the UI right away without manual refreshing.
- **Single source of truth.** The static `Inventory` class holds all parts and products, and every form reads from and writes to it.

Data is held in memory while the app runs and is not saved between sessions.

## Running it

**Requirements:** Windows and Visual Studio 2019 or later, with the **.NET desktop development** workload installed.

1. Clone the repo:
   ```bash
   git clone https://github.com/aLLmentaLx/product-inventory.git
   ```
2. Open `InventoryManagementSystem.sln` in Visual Studio.
3. Press **F5** to build and run.
