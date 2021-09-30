Feature: AdminCourseCreatePage
	As an admin
	I want to create a course
	So that I can add new trainees to the course

@Happy @AdminCourseCreate
Scenario: Admin wants to create a course
	Given I am logged in
	| email                    | password     |
    | jsmith@spartaglobal.com  | Password123! |
	And I click Courses
	When I click New
	Then I am taken to the Course create page

@Happy @AdminCourseCreate
Scenario: Admin tries to create a course with details
	Given I am logged in
	| email                    | password     |
    | jsmith@spartaglobal.com  | Password123! |
	And I click Courses
	When I click New
	And I enter the desired course details
	| Name  | Trainer | Stream  | Location | CourseLength | CourseStart |
	| Eng91 | John    | C# SDET | London   | 1           | 01012022    |
	And I click Create
	And I click Courses
	Then the new course is created

@Sad @AdminCourseCreate
Scenario: Admin tries to create a course with no details
	Given I am logged in
	| email                    | password     |
    | jsmith@spartaglobal.com  | Password123! |
	And I click Courses
	When I click New
	And I click Create
	Then I won't be returned to the course page