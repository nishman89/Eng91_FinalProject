Feature: AdminStreamEdit
	As an admin
	I want to edit a stream
	So that I can edit the details of a stream

@Happy @AdminStreamEdit
Scenario: Admin wants to edit a stream
	Given I am logged in
	| email                    | password     |
    | jsmith@spartaglobal.com  | Password123! |
	And I click Admin
	And I click Streams
	When I click Edit on 'C# Developer'
	Then I should be taken to the Edit page