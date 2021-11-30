Feature: Certification
	As a Seller on Mars
	I would like to add my Profile Details such as Certifications.
	So that buyers seeking my profile can see my Certifications.

@Add Certifications
Scenario: Adding Certification
	Given I selects the Certification tab in profile page
	And I click AddNew button
	And I enters <Certi> and <From> and <Year>
	When I click Add button
	Then The details of <Certi> should be successfully added
Examples: 
	| Certi             |   From   | Year |
	| AWS Certification |   AWS    | 2021 |

@Edit Certifications
Scenario: Editing Certification
	Given I selects the Certification tab in profile page
	And I click update icon 
	And I updates <CertiUpdate> and <FromUpdate> and <YearUpdate>
	When I click Update button
	Then The details of <CertiUpdate> should be successfully updated
Examples: 
	| CertiUpdate                | FromUpdate | YearUpdate |
	| Certification in Animation | Adobe      | 2015       |

@Delete Certifications	
Scenario: Deleteing Certification
	Given I selects the Certification tab in profile page
	When I click delete icon 
	Then The details of <CertiDel> should be successfully deleted
Examples: 
	| CertiDel                       | FromDel    | YearDel |
	| Certification in Animation |   Adobe   | 2015 |

@Invalid Certification 
Scenario: Add invalid certification datas
	Given I selects the Certification tab in profile page
	And I clicks AddNew button 
	And I enter <Certi> only 
	When I clicks Add button
	Then The details of Certification should not be added successfully
Examples: 
	| Certi             |
	| AWS Certification |

@Add invalid Certification data
Scenario: Add invalid certification data
	Given I selects the Certification tab in profile page
	And I clicks AddNew button 
	And I enter <From> only 
	When I clicks Add button
	Then The details of Certification should not be added successfully
Examples: 
	| From |
	| AWS  |

@Invalid Certification data
Scenario: Invalid Certifications
	Given I selects the Certification tab in profile page
	And I clicks AddNew button 
	And I enter <Certi> and <From> and <Year>
	And I reenter the same <Certi> and <From> and <Year>
	When I clicks Add button
	Then The details of Certification should not be added successfully
Examples:
	| Certi                      |  | From  |  | Year |
	| Certification in Animation |  | Adobe |  | 2015 |