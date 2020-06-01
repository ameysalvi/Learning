Feature: Customer_login
	Simple feature to demostrate customer login feature

@customer
Scenario: Login for customer portal
	Given I have opened the application
	And I login to application
	Then I see customer protal
