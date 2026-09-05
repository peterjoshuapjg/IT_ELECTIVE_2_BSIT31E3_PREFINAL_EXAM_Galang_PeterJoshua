**Name:** Galang, Peter Joshua F.

**Class:** IT Elective 2

**Section:** BSIT31E3

---
# IT Elective 2 – Pre-Final Exam

## Project Overview

This project is an **ASP.NET Core MVC** web application that presents the IT Elective 2 Pre-Final Exam in an organized exam interface.

The project uses the **MVC (Model-View-Controller)** architecture and does not require a database.

## Features

- ASP.NET Core MVC structure
- Exam questions displayed in a clean interface
- Question-number navigation
- Previous and Next question navigation
- Hard-coded answers
- Answers are displayed as read-only
- No database required
- Direct access to the exam interface

## Answer System

The answers are **hard-coded in the project**. They are not entered or saved by the user.

The selected answer is automatically displayed in the exam interface and cannot be changed.

This allows the instructor to run the project and immediately view the questions together with the prepared answers.

## Project Structure

```text
IT Elective 2 PreFinal Exam/
├── Controllers/
│   └── ExamController.cs
├── Models/
│   └── ExamData.cs
├── Views/
│   └── Exam/
│       └── Index.cshtml
├── wwwroot/
│   ├── css/
│   └── js/
├── Program.cs
├── appsettings.json
└── README.md
