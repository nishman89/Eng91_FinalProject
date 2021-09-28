Feature: AdminCourseCreatePage
	As an admin
	I want to create a course
	So that I can add new trainees to the course

@Happy @AdminCourseCreate
Scenario: Admin creates a course
	Given I am logged in
	And I click 'Admin'
	And I click 'Courses'
	When I click 'New'
	Then I am taken to the Course create page

@Happy @AdminCourseCreate
Scenario: Admin creates a course
	Given I am logged in
	And I click 'Admin'
	And I click 'Courses'
	When I click 'New'
	Then I am taken to the Course create page