# 🔍 LostLogic — Lost & Found Item Management System

A desktop application built with **C# Windows Forms (.NET)** that helps users report, search, and claim lost or found items. Admins can manage and verify claims through a dedicated dashboard.

---

## 📋 Table of Contents

- [About the Project](#about-the-project)
- [Features](#features)
- [Screenshots](#screenshots)
- [Tech Stack](#tech-stack)
- [Data Structures Used](#data-structures-used)
- [Project Structure](#project-structure)
- [How It Works](#how-it-works)
- [Getting Started](#getting-started)
- [File Storage](#file-storage)
- [Contributors](#contributors)

---

## 📖 About the Project

**LostLogic** is a Lost & Found management system where users can:
- Report lost or found items with photos
- Search the item database
- Submit claims for found items
- Track the status of their claims

Admins can review, verify, or reject claims through a priority-based queue system.

---

## ✨ Features

### 👤 User Side
- **Sign Up / Login** — Secure account creation with hashed passwords
- **Add Item** — Report a lost or found item with name, category, date, contact, description, and image
- **Search Items** — Search by item name and category using linear search
- **Claim Section** — Submit a claim for a found item
- **Status Tracker** — View real-time status of submitted claims (Pending / Cleared / Rejected)
- **Profile** — View user profile information
- **Pickup Location** — View where to collect a verified item

### 🛠️ Admin Side
- **Claim List** — View all pending claims sorted by priority (Electronics > Documents > Accessories)
- **Verification** — Approve or reject individual claims by Item ID
- **Logout** — Secure session exit

---

## 🛠️ Tech Stack

| Technology | Details |
|---|---|
| Language | C# |
| Framework | .NET (Windows Forms) |
| IDE | Visual Studio |
| Storage | Plain text files (`.txt`) |
| UI | WinForms with Teal/White theme |

---

## 📐 Data Structures Used

This project was built with a focus on demonstrating core **Data Structures & Algorithms (DSA)** concepts:

| DSA Concept | Where Used | Purpose |
|---|---|---|
| **Linear Search** | `SearchFound.cs` | Search items by name and category |
| **Priority Queue (Max-Heap)** | `ClaimList.cs` | Process claims in order of importance (Electronics first) |
| **SortedDictionary (BST)** | `Verification.cs` | Store and retrieve claims sorted by Item ID |
| **HashMap (Dictionary)** | `Status.cs` | Fast lookup of claim status by Item ID |
| **Simple Hashing** | `Form1.cs`, `SignUp.cs` | Password hashing for user authentication |

---

## 📁 Project Structure

```
LostLogic/
│
├── Form1.cs                  # Login form
├── SignUp.cs                 # User registration
├── Dashboard.cs              # User dashboard (main nav)
├── AdminDashboard.cs         # Admin dashboard
│
├── AddFound.cs               # Add lost/found item
├── SearchFound.cs            # Search items (Linear Search)
├── ClaimSection.cs           # Submit a claim
├── ClaimList.cs              # Admin: priority claim queue (Max-Heap)
├── Verification.cs           # Admin: verify/reject claims (SortedDictionary)
├── Status.cs                 # User: view claim status (HashMap)
├── Profile.cs                # User profile
├── PickUpLocation.cs         # Pickup point info
│
├── items.txt                 # All reported items (auto-generated)
├── claim.txt                 # Submitted claims (auto-generated)
├── user.txt                  # Registered users (auto-generated)
└── user_status.txt           # Claim status updates (auto-generated)
```

---

## ⚙️ How It Works

### User Flow
```
Login / Sign Up
     ↓
User Dashboard
     ↓
┌────────────────────────────────────────┐
│  Add Item  │  Search  │  Claim  │  Status  │
└────────────────────────────────────────┘
```

### Admin Flow
```
Admin Login (username: admin / password: admin123)
     ↓
Admin Dashboard
     ↓
┌───────────────────────────┐
│  Claim List  │  Verification  │
└───────────────────────────┘
```

### Claim Priority (Max-Heap)
Claims are processed in this order:
1. 🥇 **Electronics** — Priority 3
2. 🥈 **Documents** — Priority 2
3. 🥉 **Accessories** — Priority 1

---

## 🚀 Getting Started

### Prerequisites
- Windows OS
- Visual Studio 2022 or later
- .NET 6.0 / .NET 8.0 SDK

### Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/your-username/LostLogic.git
   ```

2. **Open in Visual Studio**
   - Open `LostLogic.slnx` in Visual Studio

3. **Build the project**
   - Press `Ctrl + Shift + B` or go to **Build → Build Solution**

4. **Run the application**
   - Press `F5` or click **Start**

> ⚠️ The `.txt` data files (`items.txt`, `claim.txt`, `user.txt`, `user_status.txt`) are auto-created on first use. No database setup required.

---

## 💾 File Storage

All data is stored in plain text files using `|` as a delimiter:

| File | Contents | Format |
|---|---|---|
| `user.txt` | Registered users | `username\|hashedPassword\|email` |
| `items.txt` | Reported items | `id\|name\|type\|category\|date\|contact\|location\|description\|imagePath` |
| `claim.txt` | Submitted claims | `id\|name\|category\|date\|contact\|location\|description` |
| `user_status.txt` | Claim decisions | `id\|name\|category\|status` |

---

## 👥 Contributors

| Name | Role |
|---|---|
| Kashaf Akmal | Developer |

---

## 📄 License

This project is for educational purposes. Feel free to fork and build on it!



