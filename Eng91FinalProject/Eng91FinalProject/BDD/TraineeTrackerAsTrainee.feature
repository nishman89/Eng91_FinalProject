Feature: TraineeTrackerAsTrainee
	Automation Task - View trainee tracker as trainee

@Login_As_Trainee
Scenario: Check tracker as Trainee
	Given I am logged in
	| email                      | password     |
	| pbridgers@spartaglobal.com | Password123! |
	When I press Tracker
	Then I should see my trackers

	
@Trainee_EditTracker
Scenario: Edit tracker
	Given I am logged in
	| email                      | password     |
	| pbridgers@spartaglobal.com | Password123! |
	When I press Tracker
	And I press Edit
	Then The window to edit the tracker appears
