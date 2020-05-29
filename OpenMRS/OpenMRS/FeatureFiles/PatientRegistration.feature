Feature: Patient registration and management
	Patient should be able to register
	Find the registered Patient
	View the record of register Patient

Background: 
Given OpenMRS site is open in a browser

@Login
Scenario: Login with Super User or Admin for Patient registration
	Given I enter admin username
	And I enter admin password
	When I select Registration Desk location
	And I press Log In button
	Then I should be able to login into the Registration Desk with Super User or Admin
