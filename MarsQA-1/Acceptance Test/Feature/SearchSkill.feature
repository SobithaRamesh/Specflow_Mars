Feature: SearchSkill

@Search from filter
Scenario: Search skill from filter
	Given The seller enters the skill in the Profile Page
	When clicks Search button 
	Then Seller can see the list of skills in a page

@Search from categories
Scenario: Search skill from catogories, subcategories
	Given The seller clicks searchskill button in the Profile Page
    When Select Category and subcategory of the skill
	Then Seller can see the list of skills in a page
