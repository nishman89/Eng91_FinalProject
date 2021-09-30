Feature: TraineeTrackerAsTrainer
	Automation Task - View trainee tracker as trainer

@Login_As_Trainer @Happy
Scenario: Check tracker as Trainer
	Given I am logged in
	| email                   | password     |
	| jsmith@spartaglobal.com | Password123! |
	When I press Trainee Tracker
	Then I should see my trainee trackers

	@Trainee_EditTracker @Happy
Scenario: Manage comment
	Given I am logged in
	| email                   | password     |
	| jsmith@spartaglobal.com | Password123! |
	When I press Trainee Tracker
	And I press Edit
	And I manage the <comment> section
	And I press save
	Then I should see my trainee trackers
	Examples: 
	| comment                     |
	| Tom Howard is better though |
	| He's great                  |

	@Trainee_EditTracker @Happy
Scenario: Manage grades
	Given I am logged in
	| email                   | password     |
	| jsmith@spartaglobal.com | Password123! |
	When I press Trainee Tracker
	And I press Edit
	And I max the first user grades
	And I press save
	Then I should see my trainee trackers
	And his grades are maxed
	
	