Feature: GetTraineeTests
	API 

@Happy @APITrainee
Scenario: Getting all trainees with valid authorisation
	Given I have an approved token
	And I make a get request for trainees
	Then I should receive a JSON of all trainees

@Happy @APITrainee
Scenario: Getting a 200 status code with valid authorisation
	Given I have an approved token
	And I make a get request for trainees
	Then I should receive a status code "200"

@Sad @APITrainee
Scenario: Getting a 400 status code with invalid authorisation
	Given I have an unapproved token
	And I make a get request for trainees
	Then I should receive a status code "400"

@Sad @APITrainee
Scenario: Getting an error message with invalid authorisation
	Given I have an unapproved token
	And I make a get request for trainees
	Then I should the error message "Invalid Token"

@Sad @APITrainee
Scenario: Getting an error message with disabled authorisation
	Given I have a disabled token
	And I make a get request for trainees
	Then I should the error message "apiKey disabled, please contact an administrator"