Feature: PostTokenTests
	API post token requests

@Happy @APIToken
Scenario: Getting a token with valid key
	Given I have an approved key
	And I make a request for a token
	Then I should recieve a valid token