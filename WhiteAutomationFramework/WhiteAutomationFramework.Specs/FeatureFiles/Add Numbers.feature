Feature: Add Numbers
	
	Background: 
	Given the calculator application is open

	Scenario: Add Numbers
	When I click button one
	And I click plus
	And I click button two
	And I click equals
	Then the result should be "3"