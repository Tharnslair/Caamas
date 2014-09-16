# C# Equality and Comparison
---

## Why is Equality so hard???
---

- System.Object (all things are defined) four methods for equality
- 9 different interfaces

**Aims of the course**

- know how to use all the methods/interfaces
- Understand equality and comparisons in .Net out of the box
- Know how to customize the equality and comparisons correctly
- C# synstax doesn't distinguish ref/value
- Multiple ways to compare values
- Accuracy for floating points is not there
- Conflict between equality, type safely, and good OO practices
---

## Reference vs. Value equality
---

**Reference types do not contain actual data, but the memory address**

- two ways to compare equality
- Same memory location?
	- Reference Equality
	- Identity
- Same value?
	- even if different locations
- Reference Equality: very quick
	- checks whether it contains the same address
- Value Equality: Slow
	- must check every field/property
---