# Ylix Car Rental (Based on Miguel Castro's PS course)

___

### Car Rental System

- WCF-based internal services
- WebApi based public API
- Asp.net MVC/Angular public facing site
	- Customer account creation and car reservations
- WFP Desktop Client
	- Used in home office to execute a rental and handle a return
	
### Goals of App

- Implementing connectivity among layers in SOA
- Patterns of Abstraction, re-usability, and test-ability among all layers
- Code elegance, cleanliness, and manageability
- Give you a great kick-off point for any future apps
	- use for new applications
### Software Configuration Management

- Flat folder structure for simplicity
- Project/folder naming implies relationships
	- Dot Notation for project and folder naming
- Abstraction held in own project
	- Facilities test dependencies

## What is Service Oriented Architecture & Applications (SOA)
---

> The decompostion of a system into autonomous or nearly autonomous units of responsibility and exposure

- Decomposition can take various forms (functional, volatility-based)
- Either case, services "orchestrate/manage" and expose functionality

---

## Evolution s of Software Development

---

**Procedural Programmming**

- apps were developed by continually calling functions based on steps to be taken in order
- Problems
	- No reuse outside of application
	- No design analogy to real world made for cumbersome development process


**Object Oriented Programming**

- Applications were built by working with various entities that resembled real world counterparts, housing both data and behavior.
- Problems
	- No reuse outside of application
	- Required lots of plumbing for managed ancillary functionality

**Component Oriented Programming**

- Objects could now be encapsulated and managed by a common abstraction layer providing loose coupleness and housed in separate libraries (DLLS)
	- Ancillary functionality typically required external service management

**Service Oriented Programming**

- Objects & Components are managed and encapsulated behind autonomous services, each with its own set of responsibilities.
- Problems
	- Needs a good "glue" technology to handle cumbersome plumbing for ancillary technologies
	- Need to accommodate interoperability 
	
---

### Characteristics of Services
---

- Simple:
	- Retrieve product record for given ID
		- In this case, service simply exposes an API for simple data access

- Complex
	- Process Order
		- Receive packaged info for order(cart info, customer, billing)
		- Update Data records for product inventory and customer history
		- Process customer credit card information
		- Build invoice and email to customer

- Have all the characteristics of a full blown app
	- Should be fault-handled
	- Should always leave system in consistent state (transactional)
	- Should be secure
	- Should handle threading properly

- A black box unit of work access-point

---

## Service Technologies
---

- WCF
	- Still the preferred tech for writing rich services
	- Provides robust model for exposing services and rich option-set
	- Still has Interoperability limations to poorly tooled clients

- Web Api
	- Less rich in offered service characteristics
	- Promotes a REST-oriented design
	- Offers great interoperability

- SQL Server
- Entity Framework(code-first)
- Managed Extensibility Framework
- Asp.net MVC
- Angular JS
- Bootstrap
- Windows Presentation Foundation
- Assorted Libraries throughout:
	- Moment.js time in JS
	- MahApps (WPF-Styling)
	- Fluent Validation(rules engine)

---

## The database
---

See db :)

---
___