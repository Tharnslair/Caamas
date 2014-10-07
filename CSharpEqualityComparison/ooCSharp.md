# Object Oriented C Sharp
---

> Ylix Content Management (Ylix is a planet in the star wars universe)

### Building the Business Layer
---

#### Working with Objects
---

    Customer customer = new Customer();

    Object Variable => New Instance of the Customer Class

    var customer = new Customer();

Setting and getting data using C# properties:

    customer.LastName = "whatever";

The static modifier

    public static int InstanceCount { get; set; }
    Customer.InstanceCount += 1;

Tips

- as you are coding considering writing the test right after writing the code!!!

---

#### Other Terms

Method Signature

- the name and type of its formal parameters
- does not include return type

Overloading

- methods that have the same name, but different parameters

Contract

- all of the properties and methods defined using public access modifier
- class makes a promise to supply the props and methods to any other code that needs them
- class interface???

Constructors

- no parameters is the default constructor

---

## Separating Responsibilities

**Classes are coupled to the Data Access Layer (DAL)

- Extract Retrieve and Save operations into a separate class
- Low coupling = high Cohesion (feature requests only touch a fewer number of classes)

#### Design Patterns
---
- common practices for designing a set of classes
- Repository Pattern 

---
	
### Defining Relationships
--- 

**Object Relationships**

- Collaboration (Uses A) relationship [CustomerRepository |uses| Customer]
- Composition (has A) relationship [Order|has| Customer, OrderItem, Address]
	- Aggregation
- IEnumberable -- recommended way to return a sequence of data

---

**Inheritance**

> Also referred to as specialization

---

Base Class : Customer

Derived or Child Classes (derive functionality from the base class):
(has an "is a" relationship with base class)
- Residential
- Business
- Government
- Educator

---
---