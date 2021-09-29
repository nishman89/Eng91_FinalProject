Feature: AdminCourseDeletePage
	As an admin
	I want to delete a course
	So that I can remove a course from the delete

@Happy @AdminCourseDelete
Scenario: Admin wants to delete a course
	Given I am logged in
	| email                    | password     |
    | jsmith@spartaglobal.com  | Password123! |
	And I click Courses
	When I click Delete on 'Engineering 81'
	Then I should be taken to the delete course page