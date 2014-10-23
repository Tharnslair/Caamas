# SQL Server Basic Modification Notes


## Different Categories of SQL statments

+ Data Definiton Language
+ Data Control Language
+ Data Modification Language

## Table metadata

+ relationships between tables should be understood
+ stored procedures and system catalogs can be used to learn more about a table
+ be aware of triggers that might cause surprise side effects to your data modifications 

## Using sp_help


+ sp_help[[@objname]'name'] 
+ sp's can be used to return an objects metadata
+ requires public role membership and at least one permission granted on table
+ also need VIEW DEFINITION permission required for seeing constraint references


+ For tables, sp_help returns(abridge):
    Column name
    Data type
    computed(yes/no)
    Length,precision,scale
    Nullability(yes/no)
    Collation

+ sp_help returns automatically-incrementing idendity columns
     column name
     seed value
     increment value
     "Not for Replication" property (true/false)

+ also includes information on GUID (rowguidcol global unique identifier) column information

## Constraint sp_help Information

+ Type of constraint
+ Constraint name
+ Delete action for foreign key constraints
+ Update action " "
+ Constraint status (enabled, disabled, N/A) for check or foreign key
+ Status for replication
+ Constrait key columns

## Catalog Views

+ Constraints, tables, sequence objects, sp's, functions, triggers, views and more

## Table Views sys.tables

+ shows one row per table in the scoped db
+ inherits columns form sys.objects and shows additional table metadata

## Column Views sys.columns

+ info returned column names, data types, identity property, ROWGUIDCOL property

### Additional Catalog view information

## Triggers

+ Data mods can fire triggers
+ people commonly forget about triggers that are performing actions behind the scenes.

+ Unexpected side-effects
+ sys.triggers returns a row for each trigger in the scoped database

+ OBJECT-DEFINITION (object_id), sp_helptext or syst.sql_modules can be used to show the text definition of the trigger

## sys.em_sql_referencing_entities

+ Added in SQL server 2008 , sys.dm_sql_referencing_entities allows you to list all references to a specific database object

+ dynamic managment object 

+ you have to have CONTROL permission on the referenced entity

## Inserting data (Module 4)

+ Backup db

## Basic Row Insert

+ Info needed???

+ Table name, column references, and data being inserted

+ Minimum permissions....INSERT permission on target table

+ N'<whatever>' unicode data type

## Column List

+ You can explicitly specify each of column of the destination table

+ enclosed in parentheses
+ delimited by columns
+ identity property and default column considerations
+ Column references can be out of order

+ You can also omit the entire column list, but it can lead to future problems

## Specifying Data Values

+ Data values are specified using the VALUES keyword:
+ INSERT INTO [myTable]([c1], [c2]) VALUES (23,23); 

## Transact-SQL Row Constructors

+ Intro in SQL 2008, you can insert multiple rows using a single statement
+ Allows you to reduce the amount of required code compared to inserting via multiple 
    statements
+ Multiple value lists, separated by commas

+ While the amount of required code is reduced, performance may be be an additional benefit

+ inserting multiple items in a single statement might be slower than using mutliple 

+ not limited to multiple row inserts

### Handling Defaults

+ If a column has a default, you can omit the column/value reference

+ Not a common scenario, but possible in scenarios where default values can be meaningful - for example in event tracking

### Derived Table and EXEC

+ DT basically a subquery, except it is always in the FROM clause of a SQL statement. The reason it is called a derived table is because it essentially functions as a table as far as the entire query is concerned.

#### Example

    select max(age) 
    from (
    -- this part of the query is a derived table:
    select age from table
    ) as Age -- must give derived table an alias

+ subqueries are used in the WHERE clause, but can also 
be used to select from one table and insert into 
another as we showed above


## Module 5 Updating Data

+ Update syntax
+ UPDATE with FROM
+ Handling defaults
+ Using compound assignment operators
+ Updating with subqueries
+ Updating data with a view

## Update -- Questions to ask

+ Which table are you updating
+ The columns and values
+ which rows updated...limit number of rows to avoid lock escalation and concurrency

+ Minimum permissions - UPDATE permission on target table

    Example:

    UPDATE <object> SET Column_name = {expression|DEFAULT|NULL};

    -- Update rows that meet a specific condition
    UPDATE [Production].[Product]
       SET [SellEndDate] = '12/31/2013',
           [ModifiedDate] = GETDATE()
    WHERE [ProductID] = 324; 
    GO

    SELECT [ProductID], [SellEndDate], [ModifiedDate]
    FROM [Production].[Product]
    WHERE [ProductID] = 324; 
    GO

    UPDATE [Production].[Product]
    SET [SellEndDate] = NULL,
       [ModifiedDate] = DEFAULT
    WHERE [ProductID] = 326; 
    GO

##  UPDATE with FROM

+ FROM<table_source> can be added to further qualify the criteria of which row gets updated

+ Common to use multiple table JOINS in FROM
+ Object in FROM same as object being updated??
    + An object alias can be used, but isn't required

+ Multiple references to the same table to be updated in the FROM clause?
    + One object must NOT specify an object alias

#### Example

    		-- UPDATE with FROM
    		UPDATE  [p]
    		SET [EmailPromotion] = 2
    		FROM[Person].[Person] AS [p]
    		INNER JOIN [Person].[BusinessEntityAddress] AS [bea]
    		ON bea.[BusinessEntityID] = p.[BusinessEntityID]
    		INNER JOIN [Person].[Address] AS [a]
    		ON a.[AddressID] = bea.[AddressID]
    		WHERE   [a].[City] = 'Darmstadt';

			## Validate Changes ##

			SELECT  [p].[BusinessEntityID] ,
			[p].[EmailPromotion]
			FROM[Person].[Person] AS [p]
			INNER JOIN [Person].[BusinessEntityAddress] AS [bea]
			ON bea.[BusinessEntityID] = p.[BusinessEntityID]
			INNER JOIN [Person].[Address] AS [a]
			ON a.[AddressID] = bea.[AddressID]
			WHERE   [a].[City] = 'Darmstadt';




## Defaults

+ Updates that don't explicitly reference a column with a default will invoke(or re-invoke) the defaults value

+ Using the ***DEFAULT*** keyword causes the default to be applied during the update
	+ Updates NULL for columns that don't actually have a default constraint

## Compound assignment operators

+ Introduced in SQL Server 2008, allows the use of a compound assignment operators in update statements

        -- Double the quantity
        UPDATE [Production].[ProductInventory]
        SET [Quantity] *= 2
        WHERE [ProductID] = 316;
        GO

    	-- What is the new quantity for each row?
    	SELECT   [ProductID] ,
    	[LocationID] ,
    	[Shelf] ,
    	[Bin] ,
    	[Quantity] 
    	FROM [Production].[ProductInventory]
    	WHERE [ProductID] = 316;
    	GO

## Updating with Sub-query values

+ Value used can be:

	+ Variable
	+ Literal value
	+ Expression


+ Sub-query enclosed in parentheses returning a single value is also permitted

#### Example

    -- Update product 708 to have 707's minimum price
    -- What is the current list price of another product
    UPDATE  [Production].[ProductListPriceHistory]
    SET [ListPrice] = ( SELECT  MIN([ListPrice])
    FROM[Production].[ProductListPriceHistory]
    WHERE   [ProductID] = 707
      )
    WHERE   [ProductID] = 708
    AND [EndDate] IS NULL;
    GO

+ Have to make sure your sub query only returns one value or it will blow up

## Updating Views

+ You can execute UPDATE statements against views

	+ Must be update-able (the view)
	+ Must reference exactly one base table in the view definition
	
	+ UPDATE must reference columns from a single base table
	
	+ Column references must be to data and not be computed columns or aggregate functions
	
	+ No TOP allowed in the view definition
	
	+ Columns modified can't be part of GROUP BY, HAVING

+ Other data modifications allowed against views include INSERT and DELETE

+ You can use an INSTEAD OF triggers are alternative modification choice.

##### Examples

    -- Check the definition of the view...set to text...better to view this way
    EXEC sys.sp_helptext '[Sales].[vSalesPerson]';
    GO
    
    -- "Before" state
    SELECT  [JobTitle]
    FROM[Sales].[vSalesPerson]
    WHERE   [BusinessEntityID] = 283;
    GO
    
    -- Modify the value
    UPDATE  [Sales].[vSalesPerson]
    SET [JobTitle] = 'Senior Sales Representative'
    WHERE   [BusinessEntityID] = 283;
    GO
    
    -- "After" state
    SELECT  [JobTitle]
    FROM[Sales].[vSalesPerson]
    WHERE   [BusinessEntityID] = 283;
    GO

----------


## DELETE statement

#### Fundamentals of the DELETE Cause
---
+ Basic Delete
	
	+ What table?
	+ Which rows?

	+ Syntax to delete ALL rows from table:
		+ DELETE <(object)>;
	
	+ Basic syntax - delete specific rows base on search condition
		+ DELETE "Object" WHERE "Search_Conditon"
		




+ WHERE clause with delete
+ FROM clause with delete

	+ use these to specify which rows will be deleted
	+ **WHERE** clause contains the search conditions
	+ use of sub-queries as part of the predicate
	+ **FROM** clause can be used to:
		+ determine qualifying rows
		+ join multiple tables, with corresponding rows deleted from the initial **FROM** clause

#### Delete vs. Truncate Table
---

+ DELETE allows you to limit the rows being deleted using search conditions
	+ able to apply finer-tuned permissions

+ TRUNCATE deletes all rows from a table
	+ does not have a **WHERE** clause
	+ Faster than **DELETE** due to reduced amount of transaction log records generated
	+ **CANNOT** be used with tables referenced by foreign keys!!!
	+ Can't be used for tables participating in indexed views, transactional replication, or merge replication 
	+ Minimum permission for ALTER on table:
		+ ALTER permission on table





