@GoogleHomePage
Feature: Google Search Steps
  
@Positive
Scenario: Google search for positive scenario
	Given User is on Google search page
	When User search 'Aviva' in search field
	Then User should see '7' links returned in the first search page
	And Print the fifth link text

@Negative
Scenario: Google search for negative scenario
	Given User is on Google search page
	When User search '' in search field
	Then User should see '0' links returned in the first search page
	And Print the fifth link text
