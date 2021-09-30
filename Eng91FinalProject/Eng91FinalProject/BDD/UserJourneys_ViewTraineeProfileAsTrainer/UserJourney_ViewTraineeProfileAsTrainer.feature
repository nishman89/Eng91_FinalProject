Feature: UserJourney_ViewTraineeProfileAsTrainer
	View trainee profile as trainer

@Trainer_profiles_page @Happy
Scenario: View student profile 1
Given I am logged in
| Email                   | Password     |
| jsmith@spartaglobal.com | Password123! |
When I click 'Profiles'
And I click on a trainee's profile
Then I can view that trainee's profile