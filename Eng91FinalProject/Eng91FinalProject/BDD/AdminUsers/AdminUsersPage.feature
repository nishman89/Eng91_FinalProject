Feature: AdminUsersPage
	As an admin
	I want to visit the Users page
	So that I can view trainers and trainees

@Happy @AdminUsers
Scenario: Admin wants to view the admin
	Given I am logged in
	| email                    | password     |
    | jsmith@spartaglobal.com  | Password123! |
	And I click Admin
	And I click Users
	When I enter 'JSmith'
	Then the result should show 'JSmith'

@Happy @AdminUsers
Scenario: Admin wants to view the trainee
	Given I am logged in
	| email                    | password     |
    | jsmith@spartaglobal.com  | Password123! |
	And I click Admin
	And I click Users
	When I enter 'AJole'
	Then the result should show 'AJole'