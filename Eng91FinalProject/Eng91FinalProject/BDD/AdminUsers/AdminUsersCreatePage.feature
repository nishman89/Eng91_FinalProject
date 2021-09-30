Feature: AdminUsersCreatePage
	As an admin
	I want to visit the Users page
	So that I can create trainers and trainees

@Happy @AdminUserCreate
Scenario: Admin wants to create a user
	Given I am logged in
	| email                    | password     |
    | jsmith@spartaglobal.com  | Password123! |
	And I click Admin
	And I click Users
	When I click New 
	Then I should be taken to the create a user page