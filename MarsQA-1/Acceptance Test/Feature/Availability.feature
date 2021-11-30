Feature: Availability
	As a Seller on Mars
	I would like to add my Profile Details such as Availability.
	So that buyers seeking my profile can see my Availability.

@Edit Availability
Scenario: Seller's available time
	Given I selects the Availabilty in profile page
    When I updated the availability
	Then the availability should be updated

@Cancel Availability
Scenario:Cancel Seller's available time
	Given I selects the Availabilty in profile page
	When I cancel the availability while editing
	Then the availability should not be updated