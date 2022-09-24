Feature: Navigation
A short summary of the feature

@Homepage
Scenario: Visit Homepage
	Given I navigate to Integræ Solutions homepage
	Then Elegant text is shown

@Homepage @Projects
Scenario: Access Projects from menu
	Given I navigate to Integræ Solutions homepage
	When Click on Projects link
	Then Projects page is shown

@Homepage @About
Scenario: Access About from menu
	Given I navigate to Integræ Solutions homepage
	When Click on About link
	Then About page is shown

@Homepage @Comments
Scenario: Access Comments from menu
	Given I navigate to Integræ Solutions homepage
	When Click on Comments link
	Then Comments page is shown

@Homepage @Donate
Scenario: Access Donate from menu
	Given I navigate to Integræ Solutions homepage
	When Click on Donate link
	Then Donate page is shown