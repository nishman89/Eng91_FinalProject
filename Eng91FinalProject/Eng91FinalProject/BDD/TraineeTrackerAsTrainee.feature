Feature: TraineeTrackerAsTrainee
	Automation Task - View trainee tracker as trainee

@mytag
Scenario: Check tracker
	Given I am logged in
	| email                      | password     |
	| pbridgers@spartaglobal.com | Password123! |
	When I press Tracker
	Then tI should see my tracker/s