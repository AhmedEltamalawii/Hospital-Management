# 🏥 Hospital Management System – C# Console Application

---
## 🧠 Core Data Structure: Singly Linked List
This system uses a **singly linked list** as its fundamental data structure for storing and managing patient  including adding, searching, deleting, and viewing all patients records. Below are the key linked list operations implemented: [HEAD] → [Patient1|Next] → [Patient2|Next] → [Patient3|Next] → null
## 📋 Features

- ✅ Add New Patient (Auto-generated Unique ID)
- 🔍 Search Patient by **ID** or **Name**
- ❌ Delete Patient by ID
- 📃 View All Patients in a table format
- 🎯 Menu-driven console interface with input validation and feedback

---

## ⚙️ Technical Overview

- **Language**: C#  
- **Framework**: .NET Core / .NET 5+ Console Application  
- **Architecture**: OOP (Object-Oriented Programming)  
- **Design Approach**: Procedural flow with encapsulated logic in classes  
- **Persistence**: In-memory using linked list (no database)

---

## 📚 Data Structure Used

### ➤ Singly Linked List

- Each `Patient` object contains a `Next` reference to the next patient.
- This forms a **singly linked list**, allowing:
  - Efficient dynamic insertion (Append to end)
  - Sequential traversal for search and delete
  - Easy memory management

**Advantages**:
- Dynamically grows with patient entries
- No fixed size limitations like arrays
- Simple and memory-efficient for linear operations

---

## 🧠 OOP Principles Applied

| Principle         | Description |
|-------------------|-------------|
| **Encapsulation** | Patient data (name, age, contact, etc.) and logic are wrapped in the `Patient` class |
| **Abstraction**   | Users interact only with methods like `AddPatient()`, `SearchPatient()`, etc. |
| **Modularity**    | All logic is split into clearly defined methods and classes |
| **Responsibility**| Separation of concerns: UI handling vs data structure management |

---

## 🛠️ How to Run
Make sure you have [.NET SDK](https://dotnet.microsoft.com/download) installed.


