Feature: UserJourney_TrainerLogin_Tracker_Comment
	Simple calculator for adding two numbers

@EditComment @Happy
Scenario: Trainer - Manage comment section
	Given I am on the Splash Page
    And I click ‘Login’
    When I enter the following credentials
    | email                    | password     |
    | jsmith@spartaglobal.com  | Password123! |
    And I click ‘LOGIN’
	When I press Tracker
	And I press Edit
    And I manage the <comment> section
	And I press save
	Then I should see my trainee trackers
	Examples: 
	| comment                     |
	| Tom Howard is better though |
	| He's great                  |