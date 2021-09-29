Feature: PostTokenTests
	API post token requests

@Happy @APIToken
Scenario: Getting a token with valid key
	Given I have an approved key
	And I make a request for a token
	Then I should recieve a valid token

@Happy @APIToken
Scenario: Getting a 200 status code with valid key
	Given I have an approved key
	And I make a request for a token
	Then I should receive a status code "200"

@Happy @APIToken
Scenario: Getting a 200 status code in json response with valid key
	Given I have an approved key
	And I make a request for a token
	Then I should receive a status code "200" in the JSON response

@Sad @APIToken
Scenario: Getting a 400 status code with invalid key
	Given I have an invalid key
	And I make a request for a token
	Then I should receive a status code "400"

@Sad @APIToken
Scenario: Getting a 400 status code in json response with invalid key
	Given I have an invalid key
	And I make a request for a token
	Then I should receive a status code "400" in the JSON response

@Sad @APIToken
Scenario: Getting a 400 status code with disabled key
	Given I have a disabled key
	And I make a request for a token
	Then I should receive a status code "400"

@Sad @APIToken
Scenario: Getting a 400 status code in json response with disabled key
	Given I have a disabled key
	And I make a request for a token
	Then I should receive a status code "400" in the JSON response