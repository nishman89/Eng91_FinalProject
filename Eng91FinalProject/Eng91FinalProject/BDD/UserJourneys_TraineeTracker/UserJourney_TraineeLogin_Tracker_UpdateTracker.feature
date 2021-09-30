Feature: UserJourney_TraineeLogin_Tracker_UpdateTracker
	Simple calculator for adding two numbers

@UserJourney_TraineeTracker @Happy
Scenario: Manage the tracker
	Given I am on the Splash Page
    And I click ‘Login’
    When I enter the following credentials
    | email                    | password     |
    | ajolie@spartaglobal.com  | Password123! |
    And I click ‘LOGIN’
	When I press Tracker
	And I press Edit
	And I manage the Continue section with the feedback <feedback>
	And I press save
	Then I should see my trackers
	Examples: 
	| feedback         |
	| Asking questions |
	| Studying         |