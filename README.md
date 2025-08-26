# Vives-Shop

## Project Description
**Vives Shop** is a simple web application built with **ASP.NET Core MVC** that simulates an ordering system for a snack bar (*frietkot*).  
Customers can browse available items, add them to their shopping cart, and proceed to checkout — saving time at the counter.  
Administrators can manage shop items with full **CRUD** functionality.

---

## Features
- **Product Catalog** – View all available shop items.  
- **Shopping Cart** – Add, remove, and clear items. Cart state is saved in sessions.  
- **Checkout Page** – Displays order summary and different payment options.  
- **Admin Management** – Add, edit, or delete shop items.  
- **Data Persistence** – Uses SQLite for storage.  

---

## Technologies Used
- **ASP.NET Core 8.0** – Web framework  
- **Entity Framework Core** – Database ORM  
- **SQLite** – Lightweight file-based database  
- **ASP.NET Core MVC** – Architectural pattern  
- **Bootstrap** – Styling & layout  
- **Sessions + Newtonsoft.Json** – Shopping cart state handling  

---

## Project Structure
VivesShop/
│
├── Controllers/ # MVC Controllers
│ ├── HomeController.cs → Home page & shop overview
│ ├── CartController.cs → Shopping cart logic
│ └── ShopItemsController.cs → CRUD for shop items
│
├── Data/
│ ├── VivesShopContext.cs → EF Core database context
│ └── Migrations/ → Database migrations
│
├── Models/
│ └── ShopItem.cs → Data model
│
├── Views/
│ ├── Home/ → Home & Privacy pages
│ ├── Cart/ → Cart & checkout views
│ └── ShopItems/ → CRUD views for items
│
├── wwwroot/ # Static files (css, js, lib)
├── appsettings.json # Configuration (DB connection)
├── Program.cs # Application startup
└── VivesShop.db # SQLite database file

## How to Run

1.  **Clone the repository**:
    ```bash
    git clone [repository_url]
    ```
2.  **Navigate to the project directory**:
    ```bash
    cd VivesShop
    ```
3.  **Run the application**:
    ```bash
    dotnet run
    ```
    The application will launch and be accessible at the URL specified in your `launchSettings.json` file (e.g., `https://localhost:7061`).

4.  **Initial Setup**: The application will automatically create the `VivesShop.db` SQLite database file and the `ShopItems` table upon its first run if it doesn't already exist.

