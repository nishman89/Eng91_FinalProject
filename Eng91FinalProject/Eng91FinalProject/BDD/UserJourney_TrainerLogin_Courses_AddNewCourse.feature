Feature: UserJourney_TrainerLogin_Courses_AddNewCourse
	A user journey for adding a course

@mytag
Scenario: Adding a course
	Given I am on the Splash Page
	And I click ‘Login’
	When I enter the correct credentials
	And I click ‘LOGIN’
	And I click ‘Admin’
	And I click ‘Courses’ in the drop-down menu
	And I click ‘New’
	And I enter the desired course details
	And I click ‘CREATE’
	Then the new course is created