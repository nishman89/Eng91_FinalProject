Feature: AdminAPIPage
	As a trainer, 
	I want to be able to manage API keys, 
	so that I can create or delete API keys

@AdminAPIPage @Happy
Scenario: Navigate to Admin API Page
	Given I am logged in
	| Email                   | Password     |
	| jsmith@spartaglobal.com | Password123! |
	When I click ‘Admin’ 
	And I click ‘API’
	Then I am taken to the Admin API Page

@AdminAPIPage @Happy
Scenario: Disable created API but cancel
	Given I am logged in
	| Email                   | Password     |
	| jsmith@spartaglobal.com | Password123! |
	When I click ‘Admin’ 
	And I click ‘API’
	And I click ‘DISABLE’ on 'testtest'
	And I click ‘CANCEL’
	Then I am taken to the Admin API Page

@AdminAPIPage @Happy
Scenario: Disable created API
	Given I am logged in
	| Email                   | Password     |
	| jsmith@spartaglobal.com | Password123! |
	When I click ‘Admin’ 
	And I click ‘API’
	And I click ‘DISABLE’ on 'testtest'
	And I click ‘OK’
	Then the selected API is disabled on 'testtest'

@AdminAPIPage @Happy
Scenario: Reset created API but cancel
	Given I am logged in
	| Email                   | Password     |
	| jsmith@spartaglobal.com | Password123! |
	When I click ‘Admin’ 
	And I click ‘API’
	And I click ‘RESET’ on 'testtest'
	And I click ‘CANCEL’
	Then I am taken to the Admin API Page

@AdminAPIPage @Happy
Scenario: Reset created API
	Given I am logged in
	| Email                   | Password     |
	| jsmith@spartaglobal.com | Password123! |
	When I click ‘Admin’ 
	And I click ‘API’
	And I click ‘RESET’ on 'testtest'
	And I click ‘OK’
	Then the selected API is reset on 'testtest'

@AdminAPIPage @Happy
Scenario: Enable selected API but cancel
	Given I am logged in
	| Email                   | Password     |
	| jsmith@spartaglobal.com | Password123! |
	When I click ‘Admin’ 
	And I click ‘API’
	And I click ‘ENABLE’ on 'testtest'
	And I click ‘CANCEL’
	Then I am taken to the Admin API Page

@AdminAPIPage @Happy
Scenario: Enable selected API
	Given I am logged in
	| Email                   | Password     |
	| jsmith@spartaglobal.com | Password123! |
	When I click ‘Admin’ 
	And I click ‘API’
	And I click ‘ENABLE’ on 'testtest'
	And I click ‘OK’
	Then the selected API is enabled on 'testtest'

@AdminAPIPage @Happy
Scenario: Edit selected API
	Given I am logged in
	| Email                   | Password     |
	| jsmith@spartaglobal.com | Password123! |
	When I click ‘Admin’ 
	And I click ‘API’
	And I click ‘Edit’ on 'testtest'
	Then I am taken to the Admin API Edit Page

@AdminAPIPage @Happy
Scenario: View selected API
	Given I am logged in
	| Email                   | Password     |
	| jsmith@spartaglobal.com | Password123! |
	When I click ‘Admin’ 
	And I click ‘API’
	And I click the name of the API on 'testtest'
	Then the selected API information is shown on 'testtest'


@AdminAPIPage @Happy
Scenario: Delete created API but cancel
	Given I am logged in
	| Email                   | Password     |
	| jsmith@spartaglobal.com | Password123! |
	When I click ‘Admin’ 
	And I click ‘API’
	And I click ‘DELETE’ on 'test'
	And I click ‘CANCEL’
	Then I am taken to the Admin API Page

@AdminAPIPage @Happy
Scenario: Delete created API
	Given I am logged in
	| Email                   | Password     |
	| jsmith@spartaglobal.com | Password123! |
	When I click ‘Admin’ 
	And I click ‘API’
	And I click ‘DELETE’ on 'asdasd'
	And I click ‘OK’
	Then the selected API Key & Token is deleted on 'asdasd'

@AdminAPIPage @Happy
Scenario: Navigate to home from admin api page using image
	Given I am logged in
	| Email                   | Password     |
	| jsmith@spartaglobal.com | Password123! |
	When I click ‘Admin’ 
	And I click ‘API’
	And I click the Sparta Global image
	Then I am taken to the Home Page

@AdminAPIPage @Happy
Scenario: Navigate to home from admin api page using home button
	Given I am logged in
	| Email                   | Password     |
	| jsmith@spartaglobal.com | Password123! |
	When I click ‘Admin’ 
	And I click ‘API’
	And I click ‘Home’
	Then I am taken to the Home Page

@AdminAPIPage @Happy
Scenario: Navigate to profiles from admin api page
	Given I am logged in
	| Email                   | Password     |
	| jsmith@spartaglobal.com | Password123! |
	When I click ‘Admin’ 
	And I click ‘API’
	And I click ‘Profiles’
	Then I am taken to the Profiles Page

@AdminAPIPage @Happy
Scenario: Log out when on admin api page
	Given I am logged in
	| Email                   | Password     |
	| jsmith@spartaglobal.com | Password123! |
	When I click ‘Admin’ 
	And I click ‘API’
	And I click ‘Logout’
	Then I am logged out and sent to the Splash Page

@AdminAPIPage @Happy
Scenario: Navigate to trainer profile page when on admin api page
	Given I am logged in
	| Email                   | Password     |
	| jsmith@spartaglobal.com | Password123! |
	When I click ‘Admin’ 
	And I click ‘API’
	And I click my name to view my Profile Page
	Then I am taken to my Profile Page