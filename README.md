# Java Exerciser With Angular Frontend
To utilise my C# skills a colleague suggested that I rewrite one of his programs in C#.  
His program written in Kotlin can be found here: https://github.com/EWLameijer/CodingExerciseAnalyzer.

## Program overview
The program should function as follows:
- Upon start, display a list of Java exercises with columns for Name, Size, Techniques and Instructions
- Clicking an exercise will open that exercise's page
- On the exercise page show:
  - A back button, to return to the list
  - Exercise instructions
  - A text field for the user to enter their solution
  - A "Show a Solution" button
- Clicking the "Show a Solution" button will
  - Show a solution for the current exercise
  - Show two buttons, the user can decide if their answer is correct and
    click "I did it!" or "I should try again later"
- Clicking either button will open the list page again
- The User's decision is reflected on the list entries with colors
  - Blank/default color for new/unread
  - Yellow for pending/"I should try again later"
  - Green for solved

## Project plan
My plan is to write an ASP.NET API for the backend and make a webpage using Angular for the frontend.  
First I'll setup a tracer bullet to get data from a database and diplay it on a webpage:

I will decide what models to design and setup a database in a MSSQL server that will store the Java exercises.  
A Domain library will hold the models. A Data Access library will provide the database connection.  
In an ASP.NET Web API project I'll add a ProblemsController that uses a DataContext class from the Access library.  
Using Node.js and AngularCLI I'll create a webpage frontend, adding a ProblemList Component to display the API data.  
After confirming that the tracer bullet works as expected I'll start to flesh out the backend.

In the Domain library I will write interfaces with methods for reading and updating the database.  
In a Business library I will implement the methods from the interfaces.  
Before writing the logic for those methods I'll make a unit-test project to outline what each method is
expected to do. I'll then add logic to the methods until all the unit-tests pass.  
When the Business library is functional it will retrieve information from the DataContext and pass it to the API.  
In Program.cs I'll setup dependency injection with the necessary classes.  
I'll create more controller methods to handle CRUD operations.

(To do: Finish Angular description/plan)
