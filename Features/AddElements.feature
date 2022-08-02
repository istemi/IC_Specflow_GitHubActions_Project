@addElements
Feature: Add Elements
! As a user I should be able to add elements on the page. Max number of elements can be added is N.
	a. navigate to The Internet (https://the-internet.herokuapp.com/add_remove_elements/)
	b. add n number of elements
	c. assert that n number of elements exist on the page
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**


Background: Navigate to the page
	When I navigate to the herokuapp add elements page

@TestCaseNo:001
@smoke
Scenario: Add N specified number of elements on the page
	Given I am on the add-remove elements page
	When I click on the add element button <N> times
	Then I should see <N> elements on the page
Examples: 
	| N  |
	| 1  |
	| 12 |
	| 0  |


# Notes
# we use tags for grouping scenarios, we may assume each sceanrio as an independent test case
# feature is the folder containing similar scenarios
# if there is a tag on the feature header, this tag applies all scenarios in the feature
# using tags we can run some specific scenarios locally or on the pipeline e.g. regression, smoke
# Background steps run before each scenario
# the codes run in the following order - before feature - before scenario - background steps - scenario steps - after scenario - after feature 
# Scenario may have an Examples table, this scenario runs for each line of the table using provided data mentioned in the step "<tableHeader>"
# a step starting with Given means something is completed in the previous steps and we can assert this in the binded code
# a step starting with When requires and action in the binded code
# a step starting with Then is usually the last line of the scnenario for asserting the expected sitiaution, there might be many Then steps
# a step starting with And depends on the previos step, if previous step starts with "When",  "And" means "When", if previos step starts with "Then", "And" means "Then"
