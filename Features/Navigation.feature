Feature: Navigation
As a user, 
I want to be able to navigate to different pages on the 
Integræ Solutions website so that 
I can access the information and features I need.

Background:
	Given I navigate to Integræ Solutions homepage

@Homepage
Scenario: Visit Homepage
	Then Elegant text is shown

@Homepage @Projects
Scenario: Access Projects page from the menu
	When Click on Projects link
	Then Projects page is shown

@Homepage @About
Scenario: Access About page from the menu
	When Click on About link
	Then About page is shown
	
@Homepage @Comments
Scenario: Access Comments page from the menu
	When Click on Comments link
	Then Comments page is shown

@Homepage @Donate
Scenario: Access Donate page from the menu
	When Click on Donate link
	Then Donate page is shown