Feature: TrainerProfilePage
	Landing page of trainer profile

@Trainer_page
Scenario: Navigate to trainer profile page
Given I am logged in
| Email                   | Password     |
| jsmith@spartaglobal.com | Password123! |
When I click my name to view my Profile Page
Then I am taken to my Profile Page

@Trainer_page
Scenario: Edit and Save changes
Given I am logged in
| Email                   | Password     |
| jsmith@spartaglobal.com | Password123! |
When I click my name to view my Profile Page
And I click EDIT
And I update my details with the following information
| FirstName | LastName | Email              | Location   |
| Test      | Name     | test@snailmail.com | North Pole |
And I click SAVE
Then my profile is updated

#@Trainer_page
#Scenario: Edit Profile Details
#Given I am logged in
#When I click my name to view my Profile Page
#And I click EDIT
#And I update my details
#And I click SAVE
#Then my profile is updated



