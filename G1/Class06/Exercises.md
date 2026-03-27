# Exercises Class 6 📒

---

## Task 1

Create a method called NumberStats that accepts a number. This method should:

* Find out if the number is negative or positive
* Find out if the number is odd or even
* Find out if the number is decimal or integer
* After finding all the stats it should print them like this:

* **Stats for number: 25**
  * Positive
  * Integer
  * Odd

The number should be entered in the console by the user.

**Bonus**: Validate if the user is entering a number  
**Bonus**: Ask the user to press Y to try again or X to exit

---

### 🧠 Design Hint – Separate Methods

Before writing code, think about **splitting the logic**:
- One method for reading and validating user input
- One method for analyzing the number (positive/negative, integer/decimal, odd/even)
- One method for printing the results

Avoid putting all logic inside `Main`.

---

### 🤖 Copilot – Step by Step Guidance

**Step 1 – Main idea**
> Create a main method that controls the flow: input → processing → output.

**Step 2 – Input handling**
> Create a separate method that asks the user for a number and returns a valid numeric value.

**Step 3 – Number analysis**
> Create a method that receives the number and determines its stats (sign, type, parity).

**Step 4 – Output**
> Create a method that prints the stats in the exact format shown in the task.

**Bonus – Loop**
> Add logic that allows the user to repeat the process or exit.

---

### ✅ Validation & Reflection

- Does each method have **one clear responsibility**?
- Can you understand what the program does by only reading method names?
- Is `Main` short and readable?
- What logic could be reused if this was a bigger application?

---

## Task 2

Create a class User with the following:

* Id - int
* Username - string
* Password - string
* Messages - Array of strings

Create an array of users and add 3 users to it manually ( hard-coded ).

Create a Console UI that will ask the user:

* Log in - When selected the user should be asked for username and password. If the user is found print welcome message and the messages that the user has in the Messages property:
  * **Welcome NAME. Here are your messages:**
    * Message1
    * Message2
  * If not found, it should print an error message
* Register - When selected the user should be asked to enter ID, Username and password. It should then check if a there is already a username in the array of users like that. If there is, print a message that there is already a user called like that. If not, create a new user object from the information given in the console and add it to the Users array. Then print all the users by Id and Username
  * **Registration complete! Users:**
    * 23 Username1
    * 44 Username2
    * 1 Username3
    * 56 Username4

---

### 🧠 Design Hint – Separate Methods

Think in terms of **features**, not lines of code:
- One method for showing the menu
- One method for login logic
- One method for registration logic
- One method for printing users
- One helper method for finding a user

---

### 🤖 Copilot – Step by Step Guidance

**Step 1 – Model**
> Create a `User` class with the required properties.

**Step 2 – Initial data**
> Create a collection of users and populate it with hard-coded users.

**Step 3 – Menu**
> Create a method that prints the menu and returns the user’s choice.

**Step 4 – Login**
> Create a method that handles login: input, search and result message.

**Step 5 – Registration**
> Create a method that handles registration and adds a new user if valid.

**Step 6 – Program flow**
> In `Main`, call the appropriate methods based on the selected menu option.

---

### ✅ Validation & Reflection

- Is login logic separated from registration logic?
- Are usernames compared in a consistent way (case sensitivity)?
- Is your code easy to extend with a new menu option?

---



## Questions? ❓

If you have any questions during or after the class, feel free to ask.

All code examples and exercises can be found in the **GitHub repository** for this course.
