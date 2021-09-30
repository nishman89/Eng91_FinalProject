Feature: AdminUsersEdit
	As an admin
	I want to visit the Users page
	So that I can edit trainers and trainees

@Happy @AdminUsersEdit
Scenario: Admin wants to edit a user
	Given I am logged in
	| email                    | password     |
    | jsmith@spartaglobal.com  | Password123! |
	And I click Admin
	And I click Users
	When I click Edit on 'JSmith'
	Then I should be taken to the edit page