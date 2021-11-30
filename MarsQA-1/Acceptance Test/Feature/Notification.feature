Feature: Notification

@LoadMore
Scenario: Load More Notifications
	Given I selects See All hyperlink in the Notification on Profile page
	When I clicks on Load More botton if notifications are more than 5
	Then I can see all the notifications in a page

@ShowLess
Scenario: Show Less Notifications
	Given I select See All hyperlink in the Notification on Profile page
	And I clicks on Load More botton if notifications are more than 5
	When I clicks on Show less button to show less notifications
	Then I can see less notifications in a page

@Select Notification
Scenario: Selecting Notification
	When  I select See All hyperlink in the Notification on Profile page
	Then I select the Select All button
	

@Unselect Notification
Scenario: Unselecting Notifications
	Given  I select See All hyperlink in the Notification on Profile page
	When I select the Select All button
	Then I select the Unselect buttin

@Mark as read Notification
Scenario: Mark as read Notifications
	Given I select See All hyperlink in the Notification on Profile page
	And I select the Select All button
	When I select the Mark selection as read button
	Then The selected notification should be marked to do actions

@Delete Notification
Scenario: Deleting Notifications
	Given I select See All hyperlink in the Notification on Profile page
	And I select the checkbox for a particular notification to be deleted
	When I seller selects the delete icon
	Then The selected notification should be deleted

@LoadMore
Scenario: Cannot see Load More
	Given I selects Notification in Home page
	And I Click on the See All hyperlink
	When notifications is less than or equal to five
	Then I cannot see Load More botton
