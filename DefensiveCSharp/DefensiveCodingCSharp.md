Defensive Coding in C#
---

PS Course

##What is Defensive Coding?

An approach to improve software and source code, in terms of:

- General Quality..reducing the number of bugs
- Making the source code comprehensible - the source code should be readable and understandable so it is approved in a code audit
- Making the software behave in a predictable manner despite unexpected inputs or user actions

**Clean Code**

- Improves Comprehension
- Simplifies Maintenance
- Reduces Bugs
- Easy to read
- Clear intent
- Simple
- Minimal
- Thoughtful

**Testable Code + Unit Tests**

- Improves Quality
- Confirms Maintenance
- Reduces Bugs
- Testing should not be limited to Unit Tests...integration tests

**Validation and Exception Handling**

-  Improves Predictability
-  More Consistent
-  Reduces Bugs

**Topics**

C#....duh

Clean methods lead to clean application

#### Clean, Testable, and Predictable Methods

- Clear purpose
- Good name
- Focused Code
- Short Length
- Automated Code Test
	- not easy to test code in a code behind file

**Repository Pattern**

- Pattern - predefined way to build a set of code for a specific purpose
- specific set of classes that handle data access for application
- sole purpose is to hide the details of accessing the data in one place separate from entity classes

**Refactoring**

- Class Library -- contains any non UI code
	-	easier to reuse any methods in class libraries
- Methods need to be long enough to relay what the method does!!!
- any code that performs CRUD operations on data will be in the repository classes

---

###Defensive Coding
---

##### Add guards to check incoming parameters 

- Garbage in...Garbage out
- invalid, null, or unexpected values
- only let in params that are valid
- code statements that validate incoming parameters at the top of methods are called "guard clauses"
	- minimizes number of params
	- consistent parameter ordering

**You change the startup form in the Program.cs file!!!**

#### Method Overriding
---

- same operation with different types of inputs???

**Design By Contract**

- What does a method expect? (accepted and unacceptable inputs)
- What does a method guarantee? (promised returned value, error, or exceptions)
- What does a method maintain? (any properties used or set by the method)

---
###Automated Code Testing
---

Top way of defensive coding is Unit Testing...unit testing and unit Testing

- Arrange
- Act
- Assert

**Focus on Unit Testing**
---

- Code Under test

**Code First**

- Requirements
- Methods
- Testing

**Test First**

- Hmmm

**Methodology**

- Valid Inputs
- Invalid Inputs
- Guard Clause
- Assumptions
- Bug Fixes


---