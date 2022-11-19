Feature: Navigation
A short summary of the feature

Background: Navigate to homepage
	Given I navigate to Integræ Solutions homepage

@Homepage
Scenario: Visit Homepage	
	Then Elegant text is shown

@Homepage @Projects
Scenario: Access Projects from menu
	When Click on Projects link
	Then Projects page is shown

@Homepage @About
Scenario: Access About from menu
	When Click on About link
	Then About page is shown

@Homepage @Comments
Scenario: Access Comments from menu
	When Click on Comments link
	Then Comments page is shown

@Homepage @Donate
Scenario: Access Donate from menu
	When Click on Donate link
	Then Donate page is shown