Feature: AdminStreamPage
	As an admin
	I want to visit the streams page
	So that I can amend any streams, add or search

@Happy @AdminStream
Scenario: Admin wants to view C# Developer stream
	Given I am logged in
	| email                    | password     |
    | jsmith@spartaglobal.com  | Password123! |
	And I click Admin
	And I click Streams
	When I type in 'C# Developer'
	And I click Search
	Then 'C# Developer' should be returned