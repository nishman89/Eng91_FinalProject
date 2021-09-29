Feature: AdminCoursePage
	As an admin
	I want to visit the courses page
	So that I can amend any course, add or search

@Happy @AdminCourse
Scenario: Admin wants to search for a course
	Given I am logged in
	| email                    | password     |
    | jsmith@spartaglobal.com  | Password123! |
	And  I click Courses
	When I type 'Engineering 81' in search bar
	And I click Search
	Then the result should show 'Engineering 81'

@Happy @AdminCourse
Scenario: Admin wants to search for a different course
	Given I am logged in
	| email                    | password     |
    | jsmith@spartaglobal.com  | Password123! |
	And  I click Courses
	When I type 'Engineering 79' in search bar
	And I click Search
	Then the result should show 'Engineering 79'

@Sad @AdminCourse
Scenario: Admin wants to search for a course that does not exist
	Given I am logged in
	| email                    | password     |
    | jsmith@spartaglobal.com  | Password123! |
	And  I click Courses
	When I type 'Engineering 91' in search bar
	And I click Search
	Then 'Engineering 91' does not appear