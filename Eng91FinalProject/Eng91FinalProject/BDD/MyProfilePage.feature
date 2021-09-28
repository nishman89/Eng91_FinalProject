Feature: MyProfilePage
	As a trainee, 
	I want to be able to edit my profile, 
	so that I can update my details

@MyProfilePage @Happy
Scenario: View trainee profile
	Given I am logged in
	| Email                    | Password     |
	| bhoward@spartaglobal.com | Password123! |
	When I click my name to view my Profile Page
	Then I am taken to my Profile Page


@MyProfilePage @Happy
Scenario: Edit trainee profile
	Given I am logged in
	| Email                    | Password     |
	| bhoward@spartaglobal.com | Password123! |
	When I click my name to view my Profile Page
	And I click ‘EDIT’
	And I update my details
	And I click ‘SAVE’
	Then my profile is updated

