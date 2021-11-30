Feature: Education
	As a Seller on Mars
	I would like to add my Profile Details such as Education.
	So that buyers seeking my profile can see my Education.

@Add Education
Scenario: Add Education
	Given I Selects the Education tab in profile page
	And I Clicks AddNew button 
	And I Enters <CName> and <Country> and <Title> and <Degree> and <Year>
	When Select clicks Add button
	Then The details of <Title> should be added 
Examples: 
	| CName |   Country |   Title |  Degree |   Year |
	| SFR   |   India   |   B.Sc  |  CS     |   2017 |

@Edit Education
Scenario: Edit Education
	Given I Selects the Education tab in profile page
	And I Clicks update icon 
	And I Updates <CNameUp> and <CountryUp> and <TitleUp> and <DegreeUp> and <YearUp>
	When I Clicks Update button
	Then The details of <TitleUp> should be updated 
Examples: 
	| CNameUp | CountryUp | TitleUp | DegreeUp | YearUp |
	| Mephco  | India     | M.Tech  | CS       | 2018   |

@Delete Education
Scenario: Delete Education
	Given I Selects the Education tab in profile page
	When I Click delete icon
	Then The details of <TitleDel> should be deleted  
Examples: 
	| CNameDel | CountryDel | TitleDel | DegreeDel | YearDel |
	| Mephco   | India      | M.Tech   | CS        | 2017    |

@Invalid Education data
Scenario: Invalid Education
	Given I selects the Education tab in profile page
	And I clicks AddNew button 
	And I enter <CName> and <Country> and <Title> and <Degree> and <Year>
	And I reenter the same <CName> and <Country> and <Title> and <Degree> and <Year>
	When Select clicks Add button
	Then The Skill and SkillLevel should not be added successfully
Examples:
	| CName  |  | Country |  | Title  |  | Degree |  | Year |
	| Mephco |  | India   |  | M.Tech |  | CS     |  | 2017 |
	| Mephco |  | India   |  | M.Tech |  | CS     |  | 2017 |
