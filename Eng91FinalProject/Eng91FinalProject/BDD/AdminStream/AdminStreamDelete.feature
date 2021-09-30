Feature: AdminStreamDelete
	As an admin
	I want to delete a stream
	So that I can edit the details of a stream

@Happy @AdminStreamDelete
Scenario: Admin wants to delete a C# Developer stream
	Given I am logged in
	| email                    | password     |
    | jsmith@spartaglobal.com  | Password123! |
	And I click Admin
	And I click Streams
	When I click Delete on 'C# Developer'
	Then I should be taken to the Delete page

@Happy @AdminStreamDelete
Scenario: Admin wants to edit a DevOps stream
	Given I am logged in
	| email                    | password     |
    | jsmith@spartaglobal.com  | Password123! |
	And I click Admin
	And I click Streams
	When I click Delete on 'DevOps'
	Then I should be taken to the Delete page

@Happy @AdminStreamDelete
Scenario: Admin wants to edit a Business Analyst stream
	Given I am logged in
	| email                    | password     |
    | jsmith@spartaglobal.com  | Password123! |
	And I click Admin
	And I click Streams
	When I click Delete on 'Business Analyst'
	Then I should be taken to the Delete page

@Happy @AdminStreamDelete
Scenario: Admin wants to edit a Java Developer stream
	Given I am logged in
	| email                    | password     |
    | jsmith@spartaglobal.com  | Password123! |
	And I click Admin
	And I click Streams
	When I click Delete on 'Java Developer'
	Then I should be taken to the Delete page