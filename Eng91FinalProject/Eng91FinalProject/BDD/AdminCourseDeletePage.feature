Feature: AdminCourseDeletePage
	As an admin
	I want to delete a course
	So that I can remove a course from the delete

@Happy @AdminCourseDelete
Scenario: Admin wants to delete a course
	Given I am logged in
	And I click 'Admin'
	And I click 'Courses'
	When I click 'Delete'
	Then the selected course is removed