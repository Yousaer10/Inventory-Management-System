# 📦 Inventory & Reminder Management System

## 📌 Overview
The **Inventory & Reminder Management System** is designed to help businesses efficiently manage stock, customer repair reminders, and user authentication. It enhances productivity by automating inventory tracking, sending repair reminders, and improving overall business operations.

### Key Features
- ✔ **User Authentication** – Secure login, password reset, and access control.
- ✔ **Inventory Management** – Add, update, track, and delete stock items.
- ✔ **Reminder System** – Set and track customer repair reminders.
- ✔ **Adaptive High DPI System** – Optimised for different screen resolutions.
- ✔ **User-Friendly Interface** – Professional, minimalistic, and easy to navigate.
- ✔ **Automated Notifications** – Alerts for repairs and stock updates.

---

## 📂 Project Structure
```
Inventory-Reminder-System/
│── src/                    # Core application logic
│   ├── main/                # Main application components
│   ├── ui/                  # User interface design and menus
│   ├── database/            # Database connection and queries
│── assets/                  # UI icons and images
│── docs/                    # Documentation (Reports, Design, Testing)
│── README.md                # Project overview and setup guide
```

---

## 🏗️ Project Development Phases

### 1️⃣ Project Investigation
- **Problem Identified**: Manual inventory and repair tracking were inefficient.
- **Objectives**:
  - Automate stock management and notifications.
  - Provide a reminder system for repairs.
  - Implement secure user authentication.
- **Feasibility**: The system was evaluated for practicality, cost, and scalability.

### 2️⃣ Project Design
- **Database Structure**:
  - Users Table – Stores user credentials.
  - Inventory Table – Tracks stock items.
  - Reminders Table – Stores scheduled repair reminders.
- **UI Wireframes**: Created intuitive navigation and minimalistic design.
- **Security Considerations**: Implemented access control and password encryption.

### 3️⃣ Project Prototype
- ✔ **User Registration & Login**
- ✔ **Stock Entry, Update, Search, & Deletion**
- ✔ **Reminder System Implementation**
- ✔ **Basic UI Functionality**

#### Planned Enhancements:
- ❌ Improved validation & UI enhancements
- ❌ Role-based access control
- ❌ Auto stock level updates
- ❌ Additional reporting features

### 4️⃣ Prototype Redesign (Based on Feedback)
- **Improved Navigation** – Added a fixed left-side menu for better accessibility.
- **High DPI Support** – Addressed blurriness on high-resolution displays.
- **Aesthetic Enhancements** – Introduced a blue-themed UI with icons for a professional appearance.
- **Adaptive Forms** – Forms now adjust dynamically based on user actions.

### 5️⃣ Testing & Validation
- **Tested Features**:
  - ✔ **Login, Register, & Verification System**
  - ✔ **Stock Management (Add, Edit, Search, Delete)**
  - ✔ **Reminder & Repair Tracking**
  - ✔ **User Profile Management (Admin Controls)**

#### Test Case Highlights:
- ✅ Successful logins redirected to the dashboard.
- ✅ Password reset email functionality worked as expected.
- ✅ Stock updates reflected correctly in the database.
- ✅ Notifications triggered at correct times for repair reminders.
- ❌ **Issue Found**: Stock notification messages needed refinement (Fixed in redesign).

### 6️⃣ Software Development & Final Features
- **User Interface Enhancements**:
  - Clean, professional UI with a navy-blue color scheme.
  - Icons for improved navigation and accessibility.
  - Easy-to-read layouts for faster data entry.
  
- **Validation Implemented**:
  - **Presence Check** – Ensures required fields are filled.
  - **Type Check** – Prevents incorrect data types.
  - **Range Check** – Limits values to acceptable ranges.
  - **Length Check** – Ensures password and other fields meet security criteria.

- **Performance & Security**:
  - Login attempts are locked after three failed attempts.
  - Secure password storage with encryption.
  - Role-based access restrictions.

---

## ⚙️ Installation & Usage

### 🔧 Setup Instructions
1️⃣ **Clone the repository**:
   ```bash
   git clone https://github.com/Yousaer10/Inventory-Reminder-System.git
   ```
2️⃣ Open the project in your preferred IDE.
3️⃣ Run the application and log in using test credentials.

### 🔑 Default Login Credentials for Testing

| Role          | Username  | Password     | Access Level   |
|---------------|-----------|--------------|----------------|
| **Admin**     | admin     | Admin123!    | Full Access    |
| **Technician**| tech01    | Tech2023!    | Manage Repairs |
| **Sales Staff** | sales02  | Sales2023!   | Manage Stock   |

---

## 📊 Future Enhancements
- 🔹 Implement **Real-Time Stock Alerts** for low inventory.
- 🔹 Integrate **Automated Email & SMS Notifications**.
- 🔹 Develop **Advanced Reporting & Analytics Dashboard**.
- 🔹 Introduce **Multi-User Access** with Role-Based Permissions.

---