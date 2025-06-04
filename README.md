# labweb2
This repository contains my final project for the "Laboratorio Programmazione Web 2" course: a web app for the management and use of a multiplex cinema.

## Overview

The application enables complete cinema management, from movie scheduling to seat booking, with features for both users and administrators. The project was developed using **ASP.NET Core Blazor** and **Entity Framework Core** for data management.

## Folder Structure

* 📁 **`CinemaApp/`** – Contains the entire application solution:

  * 📁 `CinemaApp/` – The main Blazor Server project, organized as follows:

    * 📁 `Components/` – Components and Razor pages:

      * `Layout/` – Shared layouts and graphic templates
      * `Pages/` – Pages for users and administrators (booking, movie management, screening management, etc.)

    * 📁 `Models/` – Data models and viewmodels:

      * `Entities/` – Domain entities (Movie, Room, Screening, Ticket, etc.)
      * `ViewModels/` – Support models for display and interaction

    * 📁 `Migrations/` – Migration scripts for creating and updating the SQLite database

    * 📁 `wwwroot/` – Static files (CSS, images, JS)

    * `Program.cs` – Application entry point and service configuration

    * `appsettings.json` – Application and database connection configuration

* 📁 **`Esame/`** – Support material and documentation:

  * `FlowChart_Admin.png` – Flowchart of administrative features
  * `FlowChart_User.png` – Flowchart of user features
  * `Relazione CinemaNova.pdf` – Final report with requirements analysis, design choices, and tests

## Main Features

- Viewing movie and room schedules
- Booking and purchasing tickets with seat selection
- Possibility to download the ticket generated
- Management of screenings, movies, and rooms by staff
- Authentication and roles (user, administrator, employee)
- Purchase history and booking management
