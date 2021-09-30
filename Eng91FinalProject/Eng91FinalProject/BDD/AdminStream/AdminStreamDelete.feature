Feature: AdminStreamDelete
	As an admin
	I want to delete a stream
	So that I can edit the details of a stream

@Happy @AdminStreamDelete
Scenario: Admin wants to delete a stream
	Given I am logged in
	| email                    | password     |
    | jsmith@spartaglobal.com  | Password123! |
	And I click Admin
	And I click Streams
	When I click Delete on 'C# Developer'
	Then I should be taken to the Delete page