Feature: ManageListing

@Edit Listings
Scenario: Edit the Listing
	Given I selects edit icon from the Manage Listings Page
	When I Updates the details of the Listing 
	Then I should be able to see the updated listing

@Delete Listings
Scenario: Delete the Listing
	Given I selects delete icon from the Manage Listings Page
	When I deletes the Listing 
	Then I should not be able to see that deleted listing

@View Listings
Scenario: View the Listing
	When I selects view icon from the Manage Listings Page
	Then I should be able to see the listing