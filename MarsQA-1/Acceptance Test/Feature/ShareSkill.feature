Feature: ShareSkill

@Add ShareSkill
Scenario: Add Shareskill details
	Given I selects shareskill button on profile page
	When I enters all the details 
	Then I should be able to Save the Listings successfully

@Add Invalid ShareSkill
Scenario: Add Invalid Shareskill details
	Given I selects shareskill button on profile page
	When I does not add all the mandatory details
	Then I should not be able to Save the Listings successfully
