Feature: UserJourney_TrainerLogin_Tracker_ChangeGrades
	Simple calculator for adding two numbers

@EditGrade @Happy
Scenario: Trainer - Manage trainee grade
	Given I am on the Splash Page
    And I click ‘Login’
    When I enter the following credentials
    | email                    | password     |
    | jsmith@spartaglobal.com  | Password123! |
    And I click ‘LOGIN’
	When I press Tracker
	And I press Edit
    And I max the first user grades
	And I press save
	Then I should see my trainee trackers
	And his grades are maxed