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

@Happy @AdminStream
Scenario: Admin wants to view C# SDET stream
	Given I am logged in
	| email                    | password     |
    | jsmith@spartaglobal.com  | Password123! |
	And I click Admin
	And I click Streams
	When I type in 'C# SDET'
	And I click Search
	Then 'C# SDET' should be returned

@Happy @AdminStream
Scenario: Admin wants to view DevOps stream
	Given I am logged in
	| email                    | password     |
    | jsmith@spartaglobal.com  | Password123! |
	And I click Admin
	And I click Streams
	When I type in 'DevOps'
	And I click Search
	Then 'DevOps' should be returned

@Happy @AdminStream
Scenario: Admin wants to view Business Analyst stream
	Given I am logged in
	| email                    | password     |
    | jsmith@spartaglobal.com  | Password123! |
	And I click Admin
	And I click Streams
	When I type in 'Business Analyst'
	And I click Search
	Then 'Business Analyst' should be returned

@Happy @AdminStream
Scenario: Admin wants to view Java Developer stream
	Given I am logged in
	| email                    | password     |
    | jsmith@spartaglobal.com  | Password123! |
	And I click Admin
	And I click Streams
	When I type in 'Java Developer'
	And I click Search
	Then 'Java Developer' should be returned