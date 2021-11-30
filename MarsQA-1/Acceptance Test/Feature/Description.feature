Feature: Description
	As a Seller on Mars
	I would like to add my Profile Details such as Description.
	So that buyers seeking my profile can see my Description.
	
@Add description
Scenario: Add seller's information
	Given I selects the Description in profile page
	When I add description 
	Then the description should be saved successfully

@Add Invalid description
Scenario: Add Invalid seller's information
	Given I selects the Description in profile page
	When I add description of himself/herself for more than 600 characters
	Then the description textbox should not allow seller to type further