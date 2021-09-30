Feature: TrainerProfilePage
	Landing page of trainer profile

@Trainer_page @Happy
Scenario: Navigate to trainer profile page
Given I am logged in
| Email                   | Password     |
| jsmith@spartaglobal.com | Password123! |
When I click my name to view my Profile Page
Then I am taken to my Profile Page

@Trainer_page @Happy
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

@Trainer_page @Happy
Scenario: change stream to C# dev
Given I am logged in
| Email                   | Password     |
| jsmith@spartaglobal.com | Password123! |
When I click my name to view my Profile Page
And I click EDIT
And change my stream to 'C# Developer'
And I click SAVE
Then my profile details for course stream should show 'C# Developer'

@Trainer_page @Happy
Scenario: change stream to C# SDET
Given I am logged in
| Email                   | Password     |
| jsmith@spartaglobal.com | Password123! |
When I click my name to view my Profile Page
And I click EDIT
And change my stream to 'C# SDET'
And I click SAVE
Then my profile details for course stream should show 'C# SDET'

@Trainer_page @Happy
Scenario: change stream to Java Developer
Given I am logged in
| Email                   | Password     |
| jsmith@spartaglobal.com | Password123! |
When I click my name to view my Profile Page
And I click EDIT
And change my stream to 'Java Developer'
And I click SAVE
Then my profile details for course stream should show 'Java Developer'

@Trainer_page @Happy
Scenario: change stream to DevOps
Given I am logged in
| Email                   | Password     |
| jsmith@spartaglobal.com | Password123! |
When I click my name to view my Profile Page
And I click EDIT
And change my stream to 'DevOps'
And I click SAVE
Then my profile details for course stream should show 'DevOps'

@Trainer_page @Happy
Scenario: change stream to Business Analyst
Given I am logged in
| Email                   | Password     |
| jsmith@spartaglobal.com | Password123! |
When I click my name to view my Profile Page
And I click EDIT
And change my stream to 'Business Analyst'
And I click SAVE
Then my profile details for course stream should show 'Business Analyst'

