Feature: TraineeProfile
	As a trainee, 
	I want to be able to view my profile, 
	so that I can view my details

@TraineeProfilePage @Happy
Scenario: View Trainee Profile
	Given I am logged in
	| Email                    | Password     |
	| bhoward@spartaglobal.com | Password123! |
	When I click my name to view my Profile Page
	Then I am taken to my Profile Page

@TraineeProfilePage @Happy
Scenario: Navigate to Edit Trainee Profile
	Given I am logged in
	| Email                    | Password     |
	| bhoward@spartaglobal.com | Password123! |
	When I click my name to view my Profile Page
	And I click ‘EDIT’
	Then I am taken to my Profile Edit Page


