# Q: Could you code better the feature below?
# A: Certainly! Here is an example of how you could better structure the feature:
Feature: Navigation
As a user, 
I want to be able to navigate to different pages on the 
Integræ Solutions website so that 
I can access the information and features I need.

Background: 
	Given I navigate to Integræ Solutions homepage
	#Given I am on the Integræ Solutions homepage
@Homepage
Scenario: Visit Homepage	
	Then Elegant text is shown
	#Then I should see 'Elegant' text displayed on the page

@Homepage @Projects
Scenario: Access Projects page from the menu
	When Click on Projects link
	Then Projects page is shown
	#When I click on the "Projects" link in the menu
	#Then I should be taken to the Projects page

@Homepage @About
Scenario: Access About page from the menu
	When Click on About link
	Then About page is shown
	#When I click on the "About" link in the menu
	#Then I should be taken to the About page
	
@Homepage @Comments
Scenario: Access Comments page from the menu
	When Click on Comments link
	Then Comments page is shown
	#When I click on the "Comments" link in the menu
	#Then I should be taken to the Comments page

@Homepage @Donate
Scenario: Access Donate page from the menu
	When Click on Donate link
	Then Donate page is shown
	#When I click on the "Donate" link in the menu
	#Then I should be taken to the Donate page

#	This structure more clearly defines the user's goals 
# and the actions they will take to achieve them. It also provides 
# more context for each scenario, making it easier to understand 
# the intended behavior of the feature.