Feature: UserJourney_TrainerLogin_Courses_AddNewCourse
	A user journey for adding a course

@mytag
Scenario: Adding a course
	Given I am on the Splash Page
	And I click ‘Login’
	When I enter the correct credentials
	| email                    | password     |
    | jsmith@spartaglobal.com  | Password123! |
	And I click ‘LOGIN’
	And I click ‘Admin’
	And I click ‘Courses’ in the drop-down menu
	And I click ‘New’
	And I enter the desired course details
	| Name  | Trainer | Stream  | Location | CourseLength | CourseStart |
	| Eng92 | John    | C# SDET | London   | 12           | 01012022    |
	And I click ‘CREATE’
	Then the new course is created