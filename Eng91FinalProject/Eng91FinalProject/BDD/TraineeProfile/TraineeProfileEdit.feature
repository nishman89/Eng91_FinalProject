Feature: TraineeProfileEditPage
	As a trainee, 
	I want to be able to edit my profile, 
	so that I can update my details

@TraineeProfileEditPage @Happy
Scenario: Edit trainee profile
	Given I am logged in
	| Email                    | Password     |
	| bhoward@spartaglobal.com | Password123! |
	When I click my name to view my Profile Page
	And I click ‘EDIT’
	And I update my details
	| Summary | LifeStory | CareerMotivation | Skills | Interests | Education | Certifications | AdditionalAchievements | RecentEmployment | Volunteering | LinkedIn | Github |
	| test    | test      | test             | test   | test      | test      | test           | test                   | test             | test         | test     | test   |
	And I click ‘SAVE’
	Then my profile is updated

@TraineeProfileEditPage @Happy
Scenario: Navigate to home from trainee profile edit page using image
	Given I am logged in
	| Email                    | Password     |
	| bhoward@spartaglobal.com | Password123! |
	When I click my name to view my Profile Page
	And I click ‘EDIT’
	And I click the Sparta Global image
	Then I am taken to the Home Page

@TraineeProfileEditPage @Happy
Scenario: Navigate to home from trainee profile edit page using home button
	Given I am logged in
	| Email                    | Password     |
	| bhoward@spartaglobal.com | Password123! |
	When I click my name to view my Profile Page
	And I click ‘EDIT’
	And I click ‘Home’
	Then I am taken to the Home Page

@TraineeProfileEditPage @Happy
Scenario: Navigate to profiles from trainee profile edit page
	Given I am logged in
	| Email                    | Password     |
	| bhoward@spartaglobal.com | Password123! |
	When I click my name to view my Profile Page
	And I click ‘EDIT’
	And I click ‘Profiles’
	Then I am taken to the Profiles Page

@TraineeProfileEditPage @Happy
Scenario: Log out when on trainee profile edit page
	Given I am logged in
	| Email                    | Password     |
	| bhoward@spartaglobal.com | Password123! |
	When I click my name to view my Profile Page
	And I click ‘EDIT’
	And I click ‘Logout’
	Then I am logged out and sent to the Splash Page

@TraineeProfileEditPage @Happy
Scenario: Navigate to trainee profile page when on trainee profile edit page
	Given I am logged in
	| Email                    | Password     |
	| bhoward@spartaglobal.com | Password123! |
	When I click my name to view my Profile Page
	And I click ‘EDIT’
	And I click my name to view my Profile Page
	Then I am taken to my Profile Page