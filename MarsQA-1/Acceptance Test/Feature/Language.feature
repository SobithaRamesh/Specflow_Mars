Feature: Language
	As a Seller on Mars
	I would like to add my Profile Details such as Language.
	So that buyers seeking my profile can see my Language.

@Add Language
Scenario Outline: Adding known language
	Given I selects the language tab in profile page
	And I clicks AddNew button 
	And I enter <lang> and <level>
	When I clicks Add button	
	Then <lang> should be successfully added

Examples:
	| lang    |  level            |
	| English |  Conversational   |

@Edit Language
Scenario Outline: Editing known language
	Given I selects the language tab in profile page
	And I clicks update icon 
	And I update <langUpdate> and <levelUpdate>
	When I clicks Update button
	Then <langUpdate> should be updated successfully
Examples: 
	| langUpdate |  levelUpdate      |
	| Telugu     |  Native/Bilingual |

@Delete Language
Scenario Outline: Deleteing known language
	Given I selects the language tab in profile page
	When I clicks delete icon 
	Then The <langDelete> should be deleted successfully 
Examples: 
	| langDelete | levelDelete      |
	| Telugu     | Native/Bilingual |

@Add invalid Language data
Scenario Outline: Invalid Language
	Given I selects the language tab in profile page
	And I clicks AddNew button 
	And I enter <language> only 
	When I clicks Add button
	Then The Language should not be added successfully
Examples: 
	| language |  
	| English  |  
	| Telugu   |

@Add invalid level data
Scenario Outline: Invalid level
	Given I selects the language tab in profile page
	And I clicks AddNew button 
	And I enter <level> only 
	When I clicks Add button
	Then The Language should not be added successfully
Examples: 
	| level         |
	| Conversational |
	| Native         |


@Invalid Data
Scenario Outline: Invalid Languages
	Given I selects the language tab in profile page
	And I clicks AddNew button 
	And I enter <language> and <level>
	And I reenter the same <language> and <level>
	When I clicks Add button
	Then The Language and level should not be added successfully
Examples:
	| language |  | level         |
	| English  |  | Conversational |
	| English  |  | Conversational |