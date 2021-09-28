# Documentation

This document summarises the the final training activity that was completed as a group taking part in the Engineering 91 course of the Sparta Global army. 

## Project Objective

The goal for the project was to create an automated testing framework for Web and API of the Spartan Management System, software developed previously by SpartaGlobal trainee's. The Spartan Management System was designed as a tool for Sparta Global to manage personnel information. Either being trainers or trainees. 



--Add some more stuff about project objective

## What Was Tested?

Testing was implemented  using a BDD (Behaviour Driven Development)  approach, where SpecFlow was used to facilitate this. Specflow allows  for the creation of tests that are linked to user stories using Gherkin  syntax (Given...When...Then). Selenium was then used to provide the  Webdriver  that allows the capture of the web elements on a given page.  NUnit was used for the execution of the tests. For this specific  project the aforementioned website was tested on Google Chrome browser.

For the testing of the website the POM (Page Object Model) design  pattern was used when creating the framework. Each page was represented  as class that acted as an interface between the application or site  under test. And the web elements on the page were represented by class  variables. The approach was taken as it allows for reusability,  maintainability and readability.

## Instructions for Setting Up and Running Framework

- Not sure about this section, but can add / remove later

## Class Diagrams

- Class diagrams must be added

## LivingDoc's Overview



## Project Retrospective

--blah blah

### Packages and Tools Used

| Tool or Package Used              | Version               |
| --------------------------------- | --------------------- |
| C#                                | *9.0 (double check)   |
| .Net Framework                    | *4.7.2 (double check) |
| Specflow                          | 3.9.22                |
| SpecFLow.Internal.Json            | 1.0.8                 |
| SpecFLow.NUnit                    | 3.9.22                |
| Specflow.Tools.MsBuild.Generation | 3.9.22                |
| System.ConfigurationManager       | 5.0.0                 |
| System.Security.AccessControl     | 5.0.0                 |
| System.Security.Permissions       | 5.0.0                 |
| System.ValueTuple                 | 4.4.0                 |
| NUnit                             | 3.13.1                |
| NUnit3TestAdapter                 | 4.0.0                 |
| RestSharp                         | 106.12.0              |
| Newtonsoft.Json                   | 13.0.1                |
| Cucumber.Messages                 | 6.0.1                 |
| Gherkin                           | 19.0.3                |
| Selenium.Support                  | 3.141.0               |
| Selenium.WebDriver                | 3.141.0               |
| Selenium.WebDriver.ChromeDriver   | 94.0.4604.4101        |

