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
Scenario: See tracker
	Given I am logged in
	| email                      | password     |
	| pbridgers@spartaglobal.com | Password123! |
	When I press Tracker
	And I press Edit
	Then The window to edit the tracker appears

	@Trainee_EditTracker
Scenario: Edit tracker - Stop
	Given I am logged in
	| email                      | password     |
	| pbridgers@spartaglobal.com | Password123! |
	When I press Tracker
	And I press Edit
	And I manage the Stop section with the feedback <feedback>
	And I press save
	Then I should see my trackers
	Examples: 
	| feedback         |
	| Being distracted |
	| Being late       |
	@Trainee_EditTracker
Scenario: Edit tracker - Start
	Given I am logged in
	| email                      | password     |
	| pbridgers@spartaglobal.com | Password123! |
	When I press Tracker
	And I press Edit
	And I manage the Start section with the feedback <feedback>
	And I press save
	Then I should see my trackers
	Examples: 
	| feedback              |
	| Asking more questions |
	| Studying more         |
	Scenario: Edit tracker - Continue
	Given I am logged in
	| email                      | password     |
	| pbridgers@spartaglobal.com | Password123! |
	When I press Tracker
	And I press Edit
	And I manage the Continue section with the feedback <feedback>
	And I press save
	Then I should see my trackers
	Examples: 
	| feedback         |
	| Asking questions |
	| Studying         |
