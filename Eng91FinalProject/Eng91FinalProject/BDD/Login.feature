Feature: Login
	In order to be able to observe different parts of the website
	I want to be able to sign in with particular accounts

@Login
Scenario: Valid Login - Admin
    Given I am on the Splash Page
    And I click ‘Login’
    When I enter the following credentials
    | email                    | password     |
    | jsmith@spartaglobal.com  | Password123! |
    And I click ‘LOGIN’
    Then I am taken to the Home Page

    @Login
Scenario: Valid Login - User
    Given I am on the Splash Page
    And I click ‘Login’
    When I enter the following credentials
    | email                    | password     |
    | ajolie@spartaglobal.com  | Password123! |
    And I click ‘LOGIN’
    Then I am taken to the Home Page

    @login
Scenario: Invalid Login - No username
    Given I am on the Splash Page
    And I click ‘Login’
    When I enter the following credentials
    | email | password     |
    |       | Password123! |
    And I click ‘LOGIN’
    Then I should see an alert containing the error message "The Email field is required."

    @login
Scenario: Invalid Login - No password
    Given I am on the Splash Page
    And I click ‘Login’
    When I enter the following credentials
    | email                   | password |
    | ajolie@spartaglobal.com |          |
    And I click ‘LOGIN’
    Then I should see an alert containing the error message "The Password field is required."


	

