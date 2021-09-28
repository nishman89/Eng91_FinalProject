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

@Happy @APITrainee
Scenario: Getting a 200 status code in the json response with valid authorisation
	Given I have an approved token
	And I make a get request for trainees
	Then I should receive a status code "200" in the JSON response

@Sad @APITrainee
Scenario: Getting a 401 status code with invalid authorisation
	Given I have an unapproved token
	And I make a get request for trainees
	Then I should receive a status code "401"

@Sad @APITrainee
Scenario: Getting a 401 status code in the json response with invalid authorisation
	Given I have an unapproved token
	And I make a get request for trainees
	Then I should receive a status code "401" in the JSON response

@Sad @APITrainee
Scenario: Getting an error message with invalid authorisation
	Given I have an unapproved token
	And I make a get request for trainees
	Then I should the error message "Invalid Token"

@Sad @APITrainee
Scenario: Getting a 401 status code with disabled authorisation
	Given I have a disabled token
	And I make a get request for trainees
	Then I should receive a status code "401"

@Sad @APITrainee
Scenario: Getting a 401 status code in the json response with disabled authorisation
	Given I have a disabled token
	And I make a get request for trainees
	Then I should receive a status code "401" in the JSON response

@Sad @APITrainee
Scenario: Getting an error message with disabled authorisation
	Given I have a disabled token
	And I make a get request for trainees
	Then I should the error message "apiKey disabled, please contact an administrator"