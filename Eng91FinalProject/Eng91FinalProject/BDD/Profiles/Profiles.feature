Feature: Profiles
	Simple calculator for adding two numbers


@Trainer_profiles_page
Scenario: View student profile 1
Given I am logged in
| Email                   | Password     |
| jsmith@spartaglobal.com | Password123! |
When I click 'Profiles'
And I click on a trainee's profile
Then I can view that trainee's profile

@Trainer_profiles_page
Scenario: View all Student Profiles
Given I am logged in
| Email                   | Password     |
| jsmith@spartaglobal.com | Password123! |
When I click 'Profiles'
Then I can view all of the profiles