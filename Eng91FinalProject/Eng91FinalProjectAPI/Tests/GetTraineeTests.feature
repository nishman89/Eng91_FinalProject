Feature: GetTraineeTests
	Simple calculator for adding two numbers

@Happy
Scenario: Getting all trainees with valid authorisation
	Given I have an approved token
	And I make a get request for trainees
	Then I should receive a JSON of all trainees