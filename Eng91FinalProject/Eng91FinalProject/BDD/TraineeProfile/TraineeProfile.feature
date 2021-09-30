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

@TraineeProfilePage @Happy
Scenario: Navigate to home from trainee profile edit page using image
	Given I am logged in
	| Email                    | Password     |
	| bhoward@spartaglobal.com | Password123! |
	When I click my name to view my Profile Page
	And I click the Sparta Global image
	Then I am taken to the Home Page

@TraineeProfilePage @Happy
Scenario: Navigate to home from trainee profile edit page using home button
	Given I am logged in
	| Email                    | Password     |
	| bhoward@spartaglobal.com | Password123! |
	When I click my name to view my Profile Page
	And I click ‘Home’
	Then I am taken to the Home Page

@TraineeProfilePage @Happy
Scenario: Navigate to profiles from trainee profile edit page
	Given I am logged in
	| Email                    | Password     |
	| bhoward@spartaglobal.com | Password123! |
	When I click my name to view my Profile Page
	And I click ‘Profiles’
	Then I am taken to the Profiles Page

@TraineeProfilePage @Happy
Scenario: Log out when on trainee profile edit page
	Given I am logged in
	| Email                    | Password     |
	| bhoward@spartaglobal.com | Password123! |
	When I click my name to view my Profile Page
	And I click ‘Logout’
	Then I am logged out and sent to the Splash Page

@TraineeProfilePage @Happy
Scenario: Navigate to trainee profile page when on trainee profile edit page
	Given I am logged in
	| Email                    | Password     |
	| bhoward@spartaglobal.com | Password123! |
	When I click my name to view my Profile Page
	And I click my name to view my Profile Page
	Then I am taken to my Profile Page


