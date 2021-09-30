Feature: AdminAPIEditPage
	As a trainer, 
	I want to be able to edit API keys, 
	so that I can make changes to existing API keys

@AdminAPIEditPage @Happy
Scenario: Navigate to Admin API Edit Page
	Given I am logged in
	| Email                   | Password     |
	| jsmith@spartaglobal.com | Password123! |
	When I click ‘Admin’ 
	And I click ‘API’
	And I click ‘EDIT’ on 'test'
	Then I am taken to the Admin API Edit Page

@AdminAPIEditPage @Happy
Scenario: Edit APIKey
	Given I am logged in
	| Email                   | Password     |
	| jsmith@spartaglobal.com | Password123! |
	And I click ‘Admin’ 
	And I click ‘API’
	When I click ‘EDIT’ on 'test'
	And I enter the Reference Name 'test'
	And I enter the Key Expiration date/time '2222222222222'
	And I enter the Request Limit '100'
	And I click ‘SAVE’
	Then the API Key & API Token is edited

@AdminAPIEditPage @Happy
Scenario: Navigate to home from admin api edit page using image
	Given I am logged in
	| Email                   | Password     |
	| jsmith@spartaglobal.com | Password123! |
	When I click ‘Admin’ 
	And I click ‘API’
	And I click ‘EDIT’ on 'test'
	And I click the Sparta Global image
	Then I am taken to the Home Page

@AdminAPIEditPage @Happy
Scenario: Navigate to home from admin api edit page using home button
	Given I am logged in
	| Email                   | Password     |
	| jsmith@spartaglobal.com | Password123! |
	When I click ‘Admin’ 
	And I click ‘API’
	And I click ‘EDIT’ on 'test'
	And I click ‘Home’
	Then I am taken to the Home Page

@AdminAPIEditPage @Happy
Scenario: Navigate to profiles from admin api edit page
	Given I am logged in
	| Email                   | Password     |
	| jsmith@spartaglobal.com | Password123! |
	When I click ‘Admin’ 
	And I click ‘API’
	And I click ‘EDIT’ on 'test'
	And I click ‘Profiles’
	Then I am taken to the Profiles Page

@AdminAPIEditPage @Happy
Scenario: Log out when on admin api edit page
	Given I am logged in
	| Email                   | Password     |
	| jsmith@spartaglobal.com | Password123! |
	When I click ‘Admin’ 
	And I click ‘API’
	And I click ‘EDIT’ on 'test'
	And I click ‘Logout’
	Then I am logged out and sent to the Splash Page

@AdminAPIEditPage @Happy
Scenario: Navigate to trainer profile page when on admin api edit page
	Given I am logged in
	| Email                   | Password     |
	| jsmith@spartaglobal.com | Password123! |
	When I click ‘Admin’ 
	And I click ‘API’
	And I click ‘EDIT’ on 'test'
	And I click my name to view my Profile Page
	Then I am taken to my Profile Page