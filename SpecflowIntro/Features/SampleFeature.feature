Feature: SampleFeature
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@SmokeTest
Scenario: Add two numbers
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen

Scenario: Create a new employee with mandatory detials
	#Given I have open my application
	#Then I should see employee detials page
	When I fill all the mandatory detials in form
	| Name | Age | Phone      | Email          |
	| Amey0 | 30  | 9852213654 | amey0@gmail.com |
	| Amey1 | 31  | 6548799898 | amey1@gmail.com |
	| Amey2 | 32  | 7354868914 | amey2@gmail.com |
	#And I click the save button
	#Then I should see  all the detials saved in my application and DB

Scenario Outline: Create a new employee with mandatory detials for multiple users
	#Given I have open my application
	#Then I should see employee detials page
	When I fill all the mandatory detials in form <Name>, <Age> and <Phone>
	#And I click the save button
Examples: 
	| Name | Age | Phone		|
	| Amey0 | 30  | 9852213654	|
	| Amey1 | 31  | 6548799898	|
	| Amey2 | 32  | 7354868914	|	

Scenario: Check if I could get the details entered via Table from Extended Steps
	When I fill all the mandatory details in form
		| Name | Age | Phone      | Email          |
	| Amey0 | 30  | 9852213654 | amey0@gmail.com |
	Then I should get the same value from extended steps

	 