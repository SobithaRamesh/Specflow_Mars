Feature: ManageRequest

@Recieved Requests
Scenario: Viewing Requests recieved
	Given I selects Recieved Requests from Manage Requests Tab
	Then I can be able to see the recieved requests 

@Sent Requests
Scenario: Viewing the sent Requests
	Given I selects Sent Requests from Manage Requests Tab
	Then I can be able to see the requests sent by the seller

@Invalid Recieved Requests
Scenario: Cannot view Requests recieved
	Given I selects the Manage Requests Tab
	And I clicks on the Recieved Requests option
	When I didn't recieve any requests
	Then I cannot be able to see the recieved requests

@Invalid Sent Requests
Scenario: Cannot view the sent Requests
	Given I selects the Manage Requests Tab
	And I clicks on the Sent Requests option
	When I didn't send any requests
	Then I cannot be able to see the requests sent by the seller