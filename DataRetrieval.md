Data Retrieval
---

Check available data source columns

	EXEC sp_help 'table'

## Column Aliases ##

- You can define an alias to replace the original column name or provide a column name for an expression where none already exists
- User aliases to simplify, clarify, or reduce the size of the original data source column name
- Use AS clause to define alias
	- **SELECT** '1' AS [WHATEVER]

Identifiers

- Database objects are referred to in queries using their object name
- Object names are also referred to as identifiers
- "Regular" identifiers refer to names that comply with specific rules
	- First must be a letter, (),(@),#
	- Must not be a T-SQL reserved word(upper or lower case)
	- No embedded spaces, special or supplementary characters
- "Delimited" identifiers are enclosed in double quatation marks or square brackets
- ie Department ID needs to be called using [Department ID]

---
## Semicolon Statement Terminator

- Transact-SQL terminator
- **;** will be required in the future
 
---

## Semicolon Statement Terminator

---