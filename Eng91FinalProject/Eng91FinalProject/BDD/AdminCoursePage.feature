Feature: AdminCoursePage
	As an admin
	I want to visit the courses page
	So that I can amend any course, add or search

@Happy @AdminCourse
Scenario: Admin wants to search for a course
	Given I am logged in
	And  I click Courses
	When I type 'Engineering 81' in search bar
	And I click Search
	Then the result should show 'Engineering 81'