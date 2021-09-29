Feature: AdminCourseEditPage
	As an admin
	I want to Edit a course 
	So that I can edit the details of a course

@Happy @AdminCourseEdit
Scenario: Admin edits course
	Given I am logged in
	| email                    | password     |
    | jsmith@spartaglobal.com  | Password123! |
	And I click Courses
	When I click Edit on 'Engineering 81'
	Then the selected course can be edited

@Happy @AdminCourseEdit
Scenario: Admin edits a different course
	Given I am logged in
	| email                    | password     |
    | jsmith@spartaglobal.com  | Password123! |
	And I click Courses
	When I click Edit on 'Engineering 79'
	Then the selected course can be edited