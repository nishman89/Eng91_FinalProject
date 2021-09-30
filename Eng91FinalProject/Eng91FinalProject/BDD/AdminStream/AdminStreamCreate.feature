Feature: AdminStreamCreate
	As an admin
	I want to create a stream
	So that I can add new trainees to the course

@Happy @AdminStreamCreate
Scenario: Admin wants to create a stream
	Given I am logged in
	| email                    | password     |
    | jsmith@spartaglobal.com  | Password123! |
	And I click Admin
	And I click Stream
	When I click New
	Then I should be taken to the create a stream page