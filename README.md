# 📖 Library Catalogue App
Desktop Windows Based Library Catalogue Application that Manages Books, Users, and Loans

Author: Eka Suwandi Yuliantho

------
## Screenshots
### Main Menu
<img width="748" height="456" alt="image" src="https://github.com/user-attachments/assets/d2ebc0ac-c018-4fa1-843e-75e70cf8337d" />

### Library Catalogue
<img width="1089" height="591" alt="image" src="https://github.com/user-attachments/assets/72b60201-b579-4960-b52c-abc6533a6fe7" />

### Manage Catalogue
<img width="806" height="494" alt="image" src="https://github.com/user-attachments/assets/13eb7e5d-4d51-440a-841c-6236e9e27732" />

### Manage Users
<img width="801" height="436" alt="image" src="https://github.com/user-attachments/assets/49121b16-1b93-458e-8546-6bfd623847ca" />

## Features
### Member
- Browse library catalogue
- Can search book by title, author, or year

### Staff
- Browse library catalogue
- Can search book by title, author, or year
- Manage books in the library catalogue (Add, Update, Delete)
- Manage Users (Add, Update, Delete)
- Manage Loans (Add, Update, Delete)
- Auto due date (7 Days)

### System
- Member/Staff login feature
- Fast and Responsive design
- Real-time updates
- MySQL Database intergration (localhost currently)

## Tech Stack
### IDE
Microsoft Studio 2022 .NET Framework version 4.8

### Frontend
Windows Forms App (.NET Framework)

### Backend
- MySQL Workbench Database
- MySQL Server

## Quick Start
### Prerequisites
- Using Microsoft Visual Studio 2022 Windows Machine
- Run MySQL in XAMPP
- Connected to MySQL Database Server
- Run the Project in Microsoft Visual Studio 2022

### Installations
- Nuget Package MySQL.Client

## Project Structure
<img width="435" height="505" alt="image" src="https://github.com/user-attachments/assets/f3efb4c2-3003-4ba9-9654-7bde3c5a266c" />

## Database
### ERD
![ERD library 2](https://github.com/user-attachments/assets/1d30d27e-46f3-4934-bd44-3113c3ed807d)


### Entities
Users: Stores both Staffs and Members.
Books: The inventory of the books
details: Records the borrowed books and who borrowed them

### Relationships
- Users to details (One to Many): One user can borrow many books
- Books to details (One to Many): One book can be borrowed many times

## OOP Implementations
### Encapsulation
<img width="1250" height="505" alt="image" src="https://github.com/user-attachments/assets/6f0d8a7c-39e8-42a6-8ea8-cb0ef2cad392" />

## Testing
**Total Cases:** 17
**Passed:** 17
**Success Rate:** 100%

### Test Categories
1. Login and Logout (3 Tests)
2. Library Catalogue (1 Test)
3. Catalogue Control (4 Tests)
4. User Control (4 Tests)
5. Loan Control (5 Tests)

### Test Case 
#### Example
TD1: Melakukan penambahan User jika belum ada
Precondition: Staff mode
Steps: Fill the Username, Password for the User, and the User's Role -> Click "Add"
Expected: Success Message, User Added
Result: ✅ Pass

Here are the links for the rest of the test cases: 
- Staff: https://github.com/nousername12340/Library-Catalogue-App/blob/main/Test%20Case%20Library%20Catalogue%20App%20-%20Staff.xlsx
- Member: https://github.com/nousername12340/Library-Catalogue-App/blob/main/Test%20Case%20Library%20Catalogue%20App%20-%20Member.xlsx

## Requirement
- Visual Studio 2022
- MySQL Workbench
- XAMPP
- NuGet Package MySQL.CLient

## Author
### Eka Suwandi Yuliantho

# End

  

