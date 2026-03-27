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



## Questions? ❓

If you have any questions during or after the class, feel free to ask.

All code examples and exercises can be found in the **GitHub repository** for this course.
