Feature:TrainerHomePage
	Simple tests conducted within the Trainer Home Page

@HappyTrainerTestResults
Scenario: As Trainer, view all test results
	Given I am logged in
	| email                    | password     |
    | jsmith@spartaglobal.com  | Password123! |
	When I click EXPAND ALL

	Then all test results are shown

@HappyTrainerTestResults 
Scenario: As Trainer, view individual test results
	Given I am logged in
	| email                    | password     |
    | jsmith@spartaglobal.com  | Password123! |
	When I click a trainee

	Then That trainee's test results are shown

@HappyProgressTrackerNavigation 
Scenario: As Trainer, view Progress Tracker
	Given I am logged in
	| email                    | password     |
    | jsmith@spartaglobal.com  | Password123! |
	When I click PROGRESS TRACKER

	Then I am taken to the Progress Tracker page

@HappyAttendanceNavigation
Scenario: As Trainer, view Attendance Page
	Given I am logged in
	| email                    | password     |
    | jsmith@spartaglobal.com  | Password123! |
	When I Click Course Attendance
	Then I am taken to the Course Attendance page

@HappyCourseAttendanceTests
Scenario: Check Correct Stream
	Given I am logged in
	| email                    | password     |
    | jsmith@spartaglobal.com  | Password123! |
	When I Click Course Attendance
	Then Correct stream is shown

@HappyCourseAttendanceTests
Scenario: Check Students
	Given I am logged in
	| email                    | password     |
    | jsmith@spartaglobal.com  | Password123! |
	When I Click Course Attendance
	Then All Course students are shown