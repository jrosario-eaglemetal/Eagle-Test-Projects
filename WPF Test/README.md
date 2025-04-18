## **Eagle Metal Products WPF Test**

**Goals**

 - Add a property so that a customer can be marked as active or inactive
 - Add an address table so that customers can have multiple addresses
	 - **Required Fields**
		 - Street
		 - City
		 - State (For purposes of this test this can be 2 character free text entry)
		 - Zip
	 - **Optional Fields**
		 - Street2
- Create a user interface that can do the following
	- View and select from a list of customers
	- Delete a customer
  	- View a list of addresses for a selected customer
  	- Mark an address as the primary address
	- Add a new customer
	- Toggle if a customer is active
	- Add additional addresses to a customer
- **Extras**
	- Filter customer list
	- JSON export that can export the customer data
	- JSON import to replace all customer data in the database


The base application is provided in this test as well as a sample SQLite database.
