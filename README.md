# Polyglot Microservices Pipeline (PHP & .NET)

A distributed full-stack application demonstrating inter-process communication between a PHP-based data ingestion service and an ASP.NET Core monitoring dashboard via a shared SQLite persistence layer.

## 🏗️ System Architecture

This project implements a **Producer-Consumer Pattern** across two distinct technology stacks.



- **Ingestion Service (PHP):** A lightweight, high-speed "Producer" designed for data entry.
- **Persistence Layer (SQLite):** A shared, file-based database acting as the architectural bridge.
- **Analytics Dashboard (ASP.NET Core):** A strongly-typed "Consumer" providing administrative visualization and business logic.

---

## 🚀 Execution Instructions

### 1. Start the Ingestion Service (PHP)

```bash
cd Ingestion-service
php -S localhost:8000
``` 
*Access the form at:* `http://localhost:8000/feedback-entry.html`

---

### 2. Start the Analytics Dashboard (.NET)

From the root folder:
```bash
dotnet watch
``` 
*Access the dashboard at:*`http://localhost:5000` *(or the port specified in your terminal)*

---
## 🧠 Technical Deep-Dive
**Data Ingestion (The Producer)**

   * **Frontend:** Built with **Bootstrap 5** and **JavaScript Fetch API (AJAX)**. It performs asynchronous POST requests to ensure a seamless User Experience (UX) without page reloads.

   * **Backend:** The PHP script handles input sanitization and utilizes the `PDO_SQLite` driver to commit records to the shared data layer.

**Shared Persistence (The Bridge)**

   * **Decoupling:** The architecture allows the PHP service to remain functional even if the .NET dashboard is offline.

   * **Relative Pathing:** Configured with `../` path logic to ensure the system is environment-agnostic and portable across different file systems.

**Analytics Dashboard (The Consumer)**

  * **Engine:** Built using ASP.NET Core Razor Pages.

  * **Server-Side Logic:** Implements an `IsUrgent` property within the C# Model to perform real-time keyword analysis (e.g., flagging "error" or "help") before rendering the UI.
  
  * **Dynamic Rendering:** Utilizes C# loops and conditional CSS classes to highlight priority data for administrators.
  ---
  ## 🛠️ Tech Stack
  * **Languages:** PHP 8.3, C# (Object-Oriented), JavaScript (ES6+), SQL.
  * **Frameworks:** ASP.NET Core 10.0, Bootstrap 5.
  * **Database:** SQLite 3.
  * **Tools:** Git, .NET CLI, PHP Built-in Server.
  ---
  
