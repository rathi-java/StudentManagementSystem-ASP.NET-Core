# Student Management System – ASP.NET Core MVC 🎓

Welcome to the **Student Management System** repository! 🧑‍🏫 This project is a fully functional CRUD web application built using **ASP.NET Core MVC** and **MySQL**. It allows users to manage student records with a clean and user-friendly interface. 🗂️

---

## 🌐 What's Inside?

### Core Features 🔧
- **Student Registration**: Add new students using a structured form.
- **View Students**: See all registered students in a tabular format.
- **Edit & Update**: Modify student details with a click.
- **Delete Record**: Remove student data with confirmation.
- **MySQL Integration**: Data stored and retrieved using Entity Framework Core with MySQL backend.
- **MVC Architecture**: Clean separation of concerns (Models, Views, Controllers).
- **Responsive UI**: Styled using Bootstrap 5 for smooth UX.

---

## 🧰 Tech Stack

| Layer     | Technologies                     |
|-----------|----------------------------------|
| Frontend  | HTML5, CSS3, Bootstrap 5         |
| Backend   | ASP.NET Core MVC (.NET 9 SDK)    |
| Database  | MySQL                            |
| ORM       | Entity Framework Core + Pomelo   |
| Tools     | Visual Studio 2022 / 2025, NuGet |

---

## 🛠️ Installation and Setup

### Prerequisites ✅

Ensure the following are installed on your system:

- [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download)
- [MySQL Server](https://dev.mysql.com/downloads/)
- Visual Studio (recommended) or VS Code
- Git (for version control)

---

### Step-by-Step Guide

1. **Clone the Repository**
   ```bash
   git clone https://github.com/rathi-java/StudentManagementSystem-ASP.NET-Core.git
   cd StudentManagementSystem-ASP.NET-Core

2. **Configure MySQL Connection**

   Open `appsettings.json` and update your database credentials:

   ```json
   "ConnectionStrings": {
     "DefaultConnection": "server=localhost;port=3306;database=studentdb;user=root;password=db_password"
   }
   ```

3. **Install NuGet Packages**

   Use the NuGet Package Manager or Package Manager Console:

   ```powershell
   Install-Package Microsoft.EntityFrameworkCore
   Install-Package Microsoft.EntityFrameworkCore.Design
   Install-Package Microsoft.EntityFrameworkCore.Tools
   Install-Package Pomelo.EntityFrameworkCore.MySql
   ```

4. **Create the Database (EF Core Migrations)**

   ```powershell
   Add-Migration InitialCreate
   Update-Database
   ```

5. **Run the Application**

   * Press `Ctrl + F5` in Visual Studio
   * Or use:

     ```bash
     dotnet run
     ```
   * Open in browser:

     ```
     http://localhost:<port>/Student/DisplayForm
     ```
---

## 👨‍💻 How to Use

* Navigate to `/Student/DisplayForm` to add new students.
* View all students at `/Student/GetAllStudent`.
* Edit and Delete buttons are available in the table.
* The homepage (`/`) serves as a welcome screen.

---

## ✅ Completed Functionalities

* [x] Student Create (Add Form)
* [x] Student Read (List View)
* [x] Student Update (Edit Form)
* [x] Student Delete
* [x] Fully connected to MySQL database
* [x] Routing and Navigation
* [x] Simple, modern UI using Bootstrap

---

## 🔧 Coming Soon (Ideas to Extend)

* Student profile image upload
* Search and filter functionality
* Pagination on student list
* Login system for admin/student
* Hosting on Azure or IIS

---

## 🧑‍💻 Author

* **Name:** Gourav Rathi
* **Email**: rathi.java@rathitech.com
* **GitHub:** [rathi-java](https://github.com/rathi-java)

---

## 📄 License

This project is licensed under the [MIT License](LICENSE). Feel free to use, modify, or contribute!

---

## 🙋‍♂️ Feedback or Suggestions?

Open an issue or connect via GitHub. Always open to collaboration and improvements! 🚀

```
