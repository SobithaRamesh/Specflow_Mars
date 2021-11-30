Feature: Earn Target
	As a Seller on Mars
	I would like to add my Profile Details such as Earn Target.
	So that buyers seeking my profile can see my Earn Target.
	
@Edit Earn Target
Scenario: Edit seller's Earn Target
	Given I selects the Earn Target in profile page
	When I updated his/her earn target
	Then the earn target should be updated

@Cancel Earn Target
Scenario: Cancel Seller's Earn Target
	Given I selects the Earn Target in profile page
	When I cancel his/her Earn Target while editing
	Then the Earn Target should not be updated