@feature:Navigation @severity:critical
Feature: Navigation
As a user, 
I want to be able to navigate to different pages on the 
Integræ Solutions website so that 
I can access the information and features I need.

Background:
	Given I navigate to Integræ Solutions homepage

Scenario: Visit Homepage
	Then Elegant text is shown

Scenario: Access Projects page from the menu
	When Click on Projects link
	Then Projects page is shown

Scenario: Access About page from the menu
	When Click on About link
	Then About page is shown
	
Scenario: Access Comments page from the menu
	When Click on Comments link
	Then Comments page is shown

Scenario: Access all links in the body
	Then I click in all the links and they succeed