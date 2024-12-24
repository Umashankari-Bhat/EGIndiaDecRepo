#@Sprint2
#Feature: OrangeHRMLogin
 
#A short summary of the feature
 
#Background: 
	#Given User is on the orange hrm login page
 
#@sanity
#Scenario: Verify login for orange hrm website
	#When User enters the "<usrname>" and "<passwd>" in the text fields
	#When User clicks on submit button
	#Then User is navigated to home page
#Examples: 
#| usrname | passwd   |
#| Admin   | admin123 |
 
#@regression
#Scenario Outline: Verify login for orange hrm website for invalid credentails
	#When  User enters the "<usrname>" and "<passwd>" in the text fields
	#When User clicks on submit button
	#Then Users is on the home page and a error is displayed
 
#Examples: 
#| usrname | passwd   |
#| Admin   | admin1234 |
 
@Sprint1
Feature: OrangeHRM
Test orange hrm website login functionality
@Sanity
Scenario: Verify login for orange hrm website
 
	Given user is on the orange hrm login page
 
	When user enters the "<usrname>" and "<passwd>" in the text fields
 
	When user clicks on submit button
 
	Then users is navigated to home page
Examples:
 
| usrname | passwd   |
 
| Admin   | admin123 |
 
 
@Regression
Scenario: Verify login for orange hrm website for invalid credentials
 
	Given user is on the orange hrm login page
 
	When user enters the "<usrname>" and "<passwd>" in the text fields
 
	When user clicks on submit button
 
	Then user is on home page and a error is dispalyed
Examples:
 
| usrname | passwd   |
 
| Admin   | admin13 |
 
Scenario Outline:Verify login with test parameters
	When user enter the "<username>" and "<password>"
	And user clicks on login button
	Then users is navigated to home page
	Then user select city and country onformation
	| city   | country |
	| Delhi  | India   |
	| Boston | USA     |
	Examples: 
	| username | password |
	| tom      | Harry    |
	| jerry    | Mathew   |