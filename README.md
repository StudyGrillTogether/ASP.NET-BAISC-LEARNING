# ASP.NET Core Learning Journey

A day-by-day log of my ASP.NET Core learning progress.

---

## Day 1 – Setup & Debugging Basics
**Theory**
- What is ASP.NET Core
- Installing & creating first project in Visual Studio
- Project structure overview
- Running the app
- Debugging basics (Breakpoints, Step Over / Step Into, Watching variables)

**Practice Problems**
- Run a default ASP.NET project
- Add a breakpoint and trace execution
- Modify a variable and observe output

**GitHub Exercise**
- Created a new ASP.NET Core project
- Added a simple controller returning "Hello World"
- Pushed project to GitHub, created a branch and raised a PR

---

## Day 2 – Web Fundamentals
**Theory**
- HTTP vs HTTPS
- Request & Response lifecycle
- Status codes (200, 404, 500)
- REST basics (GET, POST, PUT, DELETE)

**Practice Problems**
- Identify request types from examples
- Match status codes to scenarios

**GitHub Exercise**
- Created endpoints:
  - `/hello` → GET
  - `/user` → POST (dummy data)
- Pushed and raised a PR

---

## Day 3 – ASP.NET Core Deep Basics
**Theory**
- Middleware concept
- Program.cs flow
- Dependency Injection (basic idea)

**Practice Problems**
- Identify middleware flow order
- Explain DI in your own words

**GitHub Exercise**
- Added custom middleware to log every request to console
- Pushed and raised a PR

---

## Day 4 – MVC Introduction
**Theory**
- MVC pattern (Model, View, Controller)
- Role of each component
- Routing basics

**Practice Problems**
- Identify Model/View/Controller in examples
- Routing path exercises

**GitHub Exercise**
- Created a Controller with 2 actions
- Added basic routing for each action
- Pushed and raised a PR

---

## Day 5 – Controllers & Data Passing
**Theory**
- Controllers & Actions
- IActionResult
- Passing data using ViewBag and Model

**Practice Problems**
- Return different data types from actions
- Pass values to views

**GitHub Exercise**
- Created a page showing user details using a Model
- Pushed and raised a PR

---

## Day 6 – MVC & Razor Views
**Theory**
- MVC pattern in ASP.NET Core
- What Razor Views are
- How Layout files work
- What `_ViewStart.cshtml` does
- How data flows from Controller to View

**Practice Problems**
- Build a Product list app using MVC
- Pass data from Controller to View using a model

**GitHub Exercise**
- Built a full MVC app with Product model, Controller, Views, Layout and ViewStart
- Pushed and raised a PR

---

## Day 7 – Forms & User Input
**Theory**
- Forms in Razor
- GET vs POST forms
- Model binding

**Practice Problems**
- Create a form and submit data
- Bind form data to model

**GitHub Exercise**
- Built a simple form with Name and Email fields
- Displayed submitted data back on the page
- Pushed and raised a PR

---

## Day 8 – Database Connection & CRUD (Part 1)
**Theory**
- Connecting to a database using Dapper
- SQL queries inside C#
- Insert & Read operations

**Practice Problems**
- Write basic SQL queries
- Map database data to objects

**GitHub Exercise**
- Connected to MySQL using Dapper
- Built Insert and Read operations
- Displayed records from DB on the page
- Pushed and raised a PR

---

## Day 9 – CRUD (Part 2)
**Theory**
- Update & Delete operations
- CRUD flow in MVC
- PRG Pattern (Post-Redirect-Get)

**Practice Problems**
- Write Update and Delete queries
- Understand CRUD lifecycle

**GitHub Exercise**
- Built full CRUD app with Create, Read, Update and Delete
- Added Edit form with pre-filled data
- Added Delete functionality
- Pushed and raised a PR

---

## Day 10 – Web API Basics
**Theory**
- What is a Web API
- API vs MVC
- Returning JSON

**Practice Problems**
- Convert MVC action to API
- Identify API routes

**GitHub Exercise**
- Created a Web API with GET and POST endpoints
- Tested endpoints using Swagger
- Pushed and raised a PR

---

## Day 11 – API Advanced & Testing
**Theory**
- Route parameters
- Query parameters
- Using Swagger and Postman

**Practice Problems**
- Test API endpoints
- Pass parameters via URL

**GitHub Exercise**
- Extended API with PUT and DELETE endpoints
- Added search endpoint using query parameters
- Tested all endpoints in Swagger
- Pushed and raised a PR

---

## Day 12 – Validation & Error Handling
**Theory**
- Model validation
- Data annotations
- Try-Catch
- Handling bad requests

**Practice Problems**
- Add validation rules
- Handle invalid inputs

**GitHub Exercise**
- Added Data Annotations to User model (`[Required]`, `[EmailAddress]`, `[StringLength]`)
- Added duplicate email check using `BadRequest`
- Wrapped all endpoints in Try-Catch blocks
- Pushed and raised a PR

---

# Day 13 – Authentication Basics

## Theory
- Authentication vs Authorization
- Basic login/logout flow
- Sessions (conceptual)

## Practice Problems
- Design login flow
- Identify protected routes

## GitHub Exercise
### Build:
- Simple login system (hardcoded user)

---

# Day 14 – Deployment & Final Project

## Theory
- Publishing app
- Hosting basics
- Running in production

## Practice Problems
- Understand deployment steps
- Review full flow

## GitHub Exercise
### Final Project:
#### Mini App:
- Login
- CRUD operations
- API endpoint
- Push complete project to GitHub

## Tech Stack
- ASP.NET Core (MVC & Web API)
- C#
- MySQL with Dapper
- Swagger (Swashbuckle)
- Visual Studio 2022
- Git & GitHub

- 
