Feature:TrainerHomePage
	Simple tests conducted within the Trainer Home Page

@TrainerTestResults
Scenario: As Trainer, view all test results
	Given I am logged in
	| email                    | password     |
    | jsmith@spartaglobal.com  | Password123! |
	When I click EXPAND ALL

	Then all test results are shown

@TrainerTestResults 
Scenario: As Trainer, view individual test results
	Given I am logged in
	| email                    | password     |
    | jsmith@spartaglobal.com  | Password123! |
	When I click a trainee

	Then That trainee's test results are shown

@ProgressTrackerNavigation 
Scenario: As Trainer, view Progress Tracker
	Given I am logged in
	| email                    | password     |
    | jsmith@spartaglobal.com  | Password123! |
	When I click PROGRESS TRACKER

	And I am taken to the Progress Tracker page