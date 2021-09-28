Feature: TrainerHomePage
	Simple tests conducted within the Trainer Home Page

@Trainer test results
Scenario: As Trainer, view all test results
	Given I am logged in

	When I click ‘EXPAND ALL’

	Then all test results are shown

@Trainer test results 
Scenario: As Trainer, view individual test results
	Given I am logged in

	When I click Ben Howard

	And I click Phoebe Bridgers 

	Then Ben and Phoebe’s Test Results are shown
