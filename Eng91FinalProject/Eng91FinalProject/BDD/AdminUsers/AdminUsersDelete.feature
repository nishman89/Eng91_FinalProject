Feature: AdminUsersDelete
	As an admin
	I want to visit the Users page
	So that I can delete trainers and trainees

@Happy @AdminUserDelete
Scenario: Admin wants to delete a user
	Given I am logged in
	| email                    | password     |
    | jsmith@spartaglobal.com  | Password123! |
	And I click Admin
	And I click Users
	When I click Delete on 'JSmith'
	Then I should be taken to the delete page