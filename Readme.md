---

# MenuMate

**MenuMate** is a restaurant menu management web application built using ASP.NET Core and Entity Framework Core. This application allows restaurant owners and staff to efficiently manage ingredients, products, and categories, providing a seamless experience for handling menu items.

## Table of Contents

- [Features](#features)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
  - [Database Setup](#database-setup)
- [Project Structure](#project-structure)
- [Usage](#usage)
  - [Managing Ingredients](#managing-ingredients)
  - [Managing Products](#managing-products)
  - [Categories and Ingredients Selection](#categories-and-ingredients-selection)
- [Technologies Used](#technologies-used)
- [Contributing](#contributing)
- [License](#license)

## Features

- **Ingredient Management**: Add, edit, view, and delete ingredients.
- **Product Management**: Manage individual menu items with properties such as name, description, price, and stock.
- **Category Selection**: Assign categories to products to organize the menu structure.
- **Ingredient Selection**: Associate multiple ingredients with each product.
- **Image Uploads**: Allows uploading images for each product.
- **Responsive UI**: Designed with Bootstrap for a modern and responsive user interface.

## Getting Started

### Prerequisites

Ensure you have the following installed:

- [.NET SDK (version 8.0 or higher)](https://dotnet.microsoft.com/download)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (for database)
- [Visual Studio 2022 or Visual Studio Code](https://visualstudio.microsoft.com/) (recommended for development)

### Installation

1. Download MenuMate.zip
   Extract the file
   ```

   ```
2. Navigate into the project directory:
   ```bash
   cd MenuMate
   ```

### Database Setup

1. Update the connection string in `appsettings.json`:

   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=MenuMateDb;Trusted_Connection=True;MultipleActiveResultSets=true"
   }
   ```

2. Apply migrations to set up the database schema:

   ```bash
   dotnet ef database update
   ```

3. Run the application:
   ```bash
   dotnet run
   ```
   The application should now be accessible at `http://localhost:7033`.

## Project Structure

- **Controllers/**: Contains controllers for handling requests related to home, ingredients, and products.

  - `HomeController.cs`: Handles main navigation and homepage.
  - `IngredientController.cs`: Manages ingredient-related actions (Add, Edit, Delete, View).
  - `ProductController.cs`: Handles CRUD operations for menu items (products).

- **Data/**: Contains the database context and migration files.

  - `ApplicationDbContext.cs`: Defines the main database context for Entity Framework.
  - `Migrations/`: Contains EF Core migration files for tracking database changes.

- **Models/**: Contains the model classes defining the data structure.

  - `Ingredient.cs`: Defines the ingredient entity with properties such as `IngredientId` and `Name`.
  - `Product.cs`: Defines the product (menu item) with properties like `Name`, `Description`, `Price`, and `Stock`.
  - `Category.cs`: Defines categories for organizing products.
  - `Order.cs` and `OrderItem.cs`: Placeholder models that may represent orders in a future version.

- **Views/**: Contains Razor view files for rendering HTML.

  - `Home/`: Homepage views.
  - `Ingredient/`: Views for managing ingredients.
  - `Product/`: Views for managing products.
  - `Shared/`: Shared layout and partial views, including `_Layout.cshtml`.

- **wwwroot/**: Contains static files like CSS, JavaScript, and images.
  - `css/`: Custom styles.
  - `images/`: Placeholder images for menu items.
  - `lib/`: Contains Bootstrap and jQuery libraries for UI components.

## Usage

### Managing Ingredients

- Go to the **Ingredients** section.
- Add new ingredients by specifying the name.
- Edit or delete existing ingredients as required.

### Managing Products

- Navigate to the **Products** section.
- Add new products with details like name, description, price, and stock.
- Upload an image for each product to make the menu visually appealing.
- Edit and delete products as needed.

### Categories and Ingredients Selection

- When adding or editing a product, select a category from the available options.
- Associate ingredients with each product to give customers a detailed overview of what each item includes.

## Technologies Used

- **ASP.NET Core**: Web application framework for building and running web apps.
- **Entity Framework Core**: Object-relational mapper (ORM) for database operations.
- **Bootstrap**: CSS framework for building responsive and mobile-first web projects.
- **SQL Server**: Relational database for storing application data.

## References

- [ASP.NET Core Documentation](https://docs.microsoft.com/en-us/aspnet/core/)
- [Bootstrap Documentation](https://getbootstrap.com/)
- [Entity Framework Core Documentation](https://docs.microsoft.com/en-us/ef/core/)
- [ASP.NET Identity](https://docs.microsoft.com/en-us/aspnet/core/security/authentication/identity)
- [SQL Server Documentation](https://docs.microsoft.com/en-us/sql/sql-server/)
