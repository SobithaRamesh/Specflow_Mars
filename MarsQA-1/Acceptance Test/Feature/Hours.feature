Feature: Hours
	As a Seller on Mars
	I would like to add my Profile Details such as Hours.
	So that buyers seeking my profile can see my Hours.
@Edit Hours
Scenario: Edit seller's hours
	Given I selects the hours in profile page
	When I updated his/her hours
	Then the hours should be updated

@Cancel Hours
Scenario: Cancel Seller's available hours
	Given I selects the hours in profile page
	When I cancel his/her hours while editing
	Then the hours should not be updated