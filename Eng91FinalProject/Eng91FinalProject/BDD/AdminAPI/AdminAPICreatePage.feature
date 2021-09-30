Feature: AdminAPICreatePage
	As a trainer, 
	I want to be able to create API keys, 
	so that I can control authorisation

@AdminAPICreatePage @Happy
Scenario: Navigate to Admin API Create Page
	Given I am logged in
	| Email                   | Password     |
	| jsmith@spartaglobal.com | Password123! |
	When I click ‘Admin’ 
	And I click ‘API’
	And I click ‘NEW’
	Then I am taken to the Admin API Create Page

@AdminAPICreatePage @Happy
Scenario: Create APIKey
	Given I am logged in
	| Email                   | Password     |
	| jsmith@spartaglobal.com | Password123! |
	And I click ‘Admin’ 
	And I click ‘API’
	When I click ‘NEW’
	And I enter the Reference Name 'test'
	And I enter the Key Expiration date/time '2222222222222'
	And I enter the Request Limit '100'
	And I click ‘SAVE’
	Then a new API Key & API Token is created

@AdminAPICreatePage @Sad
Scenario: Create APIKey with taken reference name
	Given I am logged in
	| Email                   | Password     |
	| jsmith@spartaglobal.com | Password123! |
	And I click ‘Admin’ 
	And I click ‘API’
	When I click ‘NEW’
	And I enter the Reference Name 'test'
	And I enter the Key Expiration date/time '2222222222222'
	And I enter the Request Limit '100'
	And I click ‘SAVE’
	Then I should see an alert containing the error message "Reference name already exists"

@AdminAPICreatePage @Happy
Scenario: Create disabled APIKey
	Given I am logged in
	| Email                   | Password     |
	| jsmith@spartaglobal.com | Password123! |
	And I click ‘Admin’ 
	And I click ‘API’
	When I click ‘NEW’
	And I enter the Reference Name 'disabledtest'
	And I enter the Key Expiration date/time '2222222222222'
	And I enter the Request Limit '100'
	And I click ‘Disabled’
	And I click ‘SAVE’
	Then a new disabled API Key & API Token is created on 'disabledtest'

@AdminAPICreatePage @Happy
Scenario: Navigate to home from admin api create page using image
	Given I am logged in
	| Email                   | Password     |
	| jsmith@spartaglobal.com | Password123! |
	When I click ‘Admin’ 
	And I click ‘API’
	And I click ‘NEW’
	And I click the Sparta Global image
	Then I am taken to the Home Page

@AdminAPICreatePage @Happy
Scenario: Navigate to home from admin api create page using home button
	Given I am logged in
	| Email                   | Password     |
	| jsmith@spartaglobal.com | Password123! |
	When I click ‘Admin’ 
	And I click ‘API’
	And I click ‘NEW’
	And I click ‘Home’
	Then I am taken to the Home Page

@AdminAPICreatePage @Happy
Scenario: Navigate to profiles from admin api create page
	Given I am logged in
	| Email                   | Password     |
	| jsmith@spartaglobal.com | Password123! |
	When I click ‘Admin’ 
	And I click ‘API’
	And I click ‘NEW’
	And I click ‘Profiles’
	Then I am taken to the Profiles Page

@AdminAPICreatePage @Happy
Scenario: Log out when on admin api create page
	Given I am logged in
	| Email                   | Password     |
	| jsmith@spartaglobal.com | Password123! |
	When I click ‘Admin’ 
	And I click ‘API’
	And I click ‘NEW’
	And I click ‘Logout’
	Then I am logged out and sent to the Splash Page

@AdminAPICreatePage @Happy
Scenario: Navigate to trainer profile page when on admin api create page
	Given I am logged in
	| Email                   | Password     |
	| jsmith@spartaglobal.com | Password123! |
	When I click ‘Admin’ 
	And I click ‘API’
	And I click ‘NEW’
	And I click my name to view my Profile Page
	Then I am taken to my Profile Page