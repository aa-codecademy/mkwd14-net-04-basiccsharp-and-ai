# Homework Class 7

Continue from the Class07 demo solution. Add the new classes to the existing `Domain` project and create a **new Console app** called `Homework` inside the same solution. Use the models from `Domain`.

## Task 1

Add a new class `Contractor` inside `Domain/Models` that inherits from `Employee`.

- Add the following properties:
  - `WorkHours` (`double`)
  - `PayPerHour` (`int`)
  - `Responsible` (`Manager`) — the manager responsible for this contractor
- Override `CalculateAnnualBonus()` to return `WorkHours * PayPerHour`
- Add a method `GetCurrentDepartment()` that returns the department of the responsible manager

## Task 2

Add a new class `CEO` inside `Domain/Models` that inherits from `Employee`.

- Add the following properties:
  - `Employees` (`Employee[]`) — all employees in the company
  - `Shares` (`int`)
  - `SharesPrice` (`double`) — must not be settable from outside the class; the only way to change it is through a method
- Add a method `UpdateSharesPrice(double amount)` that sets the `SharesPrice`
- Add a method `PrintEmployees()` that prints the full name of every employee in the `Employees` array
- Override `CalculateAnnualBonus()` to return `Salary + Shares * SharesPrice`

## Task 3

In `Homework/Program.cs`, using the models from the `Domain` project:

- Create 2 `Developer` instances, 2 `Manager` instances, and 1 `Contractor` instance
- Create a `CEO` instance whose `Employees` array contains all 5 of the above
- Call `UpdateSharesPrice()` to set the shares price
- Print the CEO's details using `GetDetails()`
- Call `PrintEmployees()` to list all employees
- Call `CalculateAnnualBonus()` and print the result

Expected output (values are examples — use your own):
```
[1] Alice Alison, Age: 35, Salary: $8,000.00, Seniority: Lead
Employees:
Bob Bobsky
John Johnsky
...
CEO Annual Bonus: 28500
```

> You are encouraged to use AI tools such as GitHub Copilot or ChatGPT while working on this homework, but make sure you understand every line of code and do not generate the entire solution at once.
