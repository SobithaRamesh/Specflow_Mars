Feature: Chat

@Chat
Scenario: Chat
	Given I enters the skill in the Profile Page
	And I clicks Search button 
	And I select a particular seller from the list to chat with him/her
	When I click the chat button
	Then I send the meassage to that seller

@ChatHistory
Scenario: Chat History
	Given I click in the Chat button in the Profile page
	Then I click on the seller name on the left of the chat room
	

	