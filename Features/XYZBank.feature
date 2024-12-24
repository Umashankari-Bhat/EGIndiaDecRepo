Feature: XYZBank
 
A short summary of the feature
 
@customer
Scenario: Customer Login
	Given Customer is on login page
	When customer clicks on Customer Login button
	And Selects the name
	And user Clicks on login button
	Then user is logged in and can see data
@manager
Scenario: Bank Manager Login
	Given Manager is on login page
	When Customer clicks on Bank Manager Login button
	And Clicks on Add Customer Button
	And enters firstname, lastname, postalcode
	| firstname | lastname | postalcode |
	| Umashankari  | Bhat | 234567     |
	And clicks on Add new Customer Button
	Then new Customer is added



#Feature: BankXYZ

#A short summary of the feature

 #@tag1
#Scenario: Customer login
    #Given User is on the login page
    #When User clicks the customer login
    #And User selects the "<username>" from the dropdown
    #And User clicks the login button
    #And User clicks the Transaction button
    #And User clicks the Deposite button
    #And User clicks the Withdrwal button
 
#Examples: 
#| username     |
#| Harry Potter |
#| Ron Weasly   |
