﻿Feature: AdminCourseEditPage
	As an admin
	I want to Edit a course 
	So that I can edit the details of a course

@Happy @AdminCourseEdit
Scenario: Admin edits page
	Given I am logged in
	And I click Courses
	When I click Edit on 'Engineering 81'
	Then the selected course can be edited