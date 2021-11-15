@GetDemo
Feature: Get a demo in Liberis webpage

Scenario: Get a demo with no type or partner selected
	Given I navigate to Get a demo page
	When I click in Get a demo
	Then I will be prompted with Please select a type of partner