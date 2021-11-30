Feature: Skills
	As a Seller on Mars
	I would like to add my Profile Details such as Skills.
	So that buyers seeking my profile can see my Skills.

@Add Skills
Scenario Outline: Adding known skill
	Given I selects the skills tab in profile page
	And I Click AddNew button 
	And I Enter <skill> and <Slevel>
	When I Click Add button	
	Then <skill> should be added successfully

Examples:
	| skill      | Slevel       |
	| Creativity | Intermediate |

@Edit Skills
Scenario Outline: Editing known skill
	Given I selects the skills tab in profile page
	And I clicks Update icon 
	And I Update <skillUpdate> and <SlevelUpdate>
	When I Click Update button
	Then <skillUpdate> should be updated successfully
Examples: 
	| skillUpdate | SlevelUpdate |
	| Testing     | Intermediate |

@Delete Skills
Scenario: Deleteing skills
	Given I selects the skills tab in profile page
	When I Clicks delete icon 
	Then The <skillDelete>  should be deleted
Examples: 
	| skillDelete |  SlevelDelete |
	| Testing     |  Intermediate |

@Add invalid Skills data
Scenario: Adding invalid skills
	Given I selects the skills tab in profile page
	And I clicks AddNew button 
	And I enter <skill> only 
	When I clicks Add button
	Then The <skill> should not be added successfully
Examples: 
	| skill                  |
	| Active Listening Skill |

@Add invalid SkillLevel data
Scenario: Adding invalid skill level
	Given I selects the skills tab in profile page
	And I clicks AddNew button 
	And I enter <Slevel> only 
	When I clicks Add button
	Then The <Slevel> should not be added successfully
Examples: 
	| Slevel   |
	| Beginner |

@Invalid data
Scenario: Invalid Skills
	Given I selects the skills tab in profile page
	And I clicks AddNew button 
	And I enter <skill> and <Slevel>
	And I reenter the same <skill> and <Slevel>
	When I clicks Add button
	Then The <Skill> and <Slevel> should not be added successfully
Examples:
	| skill |  | Slevel       |
	| C#    |  | Intermediate |
	| C#    |  | Intermediate |