Feature: SharedLogin
	In order to be able to observe different parts of the website
	I want to be able to sign in with particular accounts

@Login
Scenario: Valid Login - Admin
    Given I am on the Splash Page
    And I click ‘Login’
    When I enter the correct credentials
    | email                    | password     |
    | jsmith@spartaglobal.com  | Password123! |
    And I click ‘LOGIN’
    Then I am taken to the Home Page


    #Given I am on the login page
    #And I enter the following <email> and <password>
    #When I enter these credentials
    #And I click the login button
    #Then I should be logged in and sent to the main page
    #| email                    | password     |
    #| jsmith@spartaglobal.com  | Password123! |
    #| bhoward@spartaglobal.com | Password123! |
    #| bpitt@spartaglobal.com   | Password123! |

	

