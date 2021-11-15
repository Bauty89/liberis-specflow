# Liberis Specflow Demo

## Approach

Test is defined following the POM model to be scalable. Actions and information retrieved from the website are taken in the PageObject class and used from the StepDefinitions class.

## Test created

```gherkin
Feature: Get a demo in Liberis webpage

Scenario: Get a demo with no type or partner selected
	Given I navigate to Get a demo page in 'https://www.liberis.com'
	When I click in Get a demo
	Then I will be prompted with 'Please select a type of partner'
```
Test defines the url, which is passed as string to the Given method implemented in the step definitions, and also defines the expected result as string passed to the Then method to assert against the string retrieved from the website.

## Execution

To execute, just import this repository with Visual Studio, build the project, and execute the tests.

# Manual Tests

## Happy Paths
```gherkin
Scenario: Get a demo as Broker
	Given I'm a Broker
	And I navigate to Get a demo page in 'https://www.liberis.com'
	When I click in Get a demo selecting I'm a Broker
	Then I will land in the form page with the broker fields to fill

Scenario: Get a demo as ISO
	Given I'm an ISO
	And I navigate to Get a demo page in 'https://www.liberis.com'
	When I click in Get a demo selecting I'm an ISO
	Then I will land in the form page with the ISO fields to fill

Scenario: Get a demo as Strategic Partner
	Given I'm a Strategic Partner
	And I navigate to Get a demo page in 'https://www.liberis.com'
	When I click in Get a demo selecting I'm a Strategic Partner
	Then I will land in the form page with the Strategic Partner fields to fill

Scenario: Continue as broker filling with all fields in form
	Given I'm a Broker
	And I'm requesting a Demo
	When I click in Submit with all fields properly filled
	Then I'll be prompted with 'Thank you for requesting a demo'

Scenario: Continue as ISO filling with all fields in form
	Given I'm an ISO
	And I'm requesting a Demo
	When I click in Submit with all fields properly filled
	Then I'll be prompted with 'Thank you for requesting a demo'

Scenario: Continue as Strategic Partner filling with all fields in form
	Given I'm a Strategic Partner
	And I'm requesting a Demo
	When I click in Submit with all fields properly filled
	Then I'll be prompted with 'Thank you for requesting a demo'
```

## Empty form test cases
```gherkin
Scenario: Continue as broker with all empty fields in form
	Given I'm a Broker
	And I'm requesting a Demo
	When I click in Submit with all fields empty
	Then I'll be prompted with an error 'Please fill in a valid value for all required fields' and not filled fields

Scenario: Continue as ISO with all empty fields in form
	Given I'm an ISO
	And I'm requesting a Demo
	When I click in Submit with all fields empty
	Then I'll be prompted with an error 'Please fill in a valid value for all required fields' and not filled fields

Scenario: Continue as Strategic Partner with all empty fields in form
	Given I'm a Strategic Partner
	And I'm requesting a Demo
	When I click in Submit with all fields empty
	Then I'll be prompted with an error 'Please fill in a valid value for all required fields' and not filled fields

Scenario: Continue as broker with some empty fields in form
	Given I'm a Broker
	And I'm requesting a Demo
	When I click in Submit with some fields empty
	Then I'll be prompted with an error 'Please fill in a valid value for all required fields' and not filled fields

Scenario: Continue as ISO with some empty fields in form
	Given I'm an ISO
	And I'm requesting a Demo
	When I click in Submit with some fields empty
	Then I'll be prompted with an error 'Please fill in a valid value for all required fields' and not filled fields

Scenario: Continue as Strategic Partner with  empty fields in form
	Given I'm a Strategic Partner
	And I'm requesting a Demo
	When I click in Submit with some fields empty
	Then I'll be prompted with an error 'Please fill in a valid value for all required fields' and not filled fields
```
## Format errors
```gherkin
Scenario: Continue as broker with non english format phone number
	Given I'm a Broker
	And I'm requesting a Demo
	When I click in Submit with Phone Number with letters / numbers non conforming the english phone format
	Then I'll be prompted with an error 'Please ensure all values are in a proper format.' and fields with errors

Scenario: Continue as ISO with non english format phone number
	Given I'm an ISO
	And I'm requesting a Demo
	When I click in Submit with Phone Number with letters / numbers non conforming the english phone format
	Then I'll be prompted with an error 'Please ensure all values are in a proper format.' and fields with errors

Scenario: Continue as Strategic Partner with non english format phone number
	Given I'm a Strategic Partner
	And I'm requesting a Demo
	When I click in Submit with Phone Number with letters / numbers non conforming the english phone format
	Then I'll be prompted with an error 'Please ensure all values are in a proper format.' and fields with errors

Scenario: Continue as broker with non rfc5322 compliant email
	Given I'm a Broker
	And I'm requesting a Demo
	When I click in Submit with non rfc5322 compliant email (non johndoe@example.xxx)
	Then I'll be prompted with an error 'Please ensure all values are in a proper format.' and fields with errors

Scenario: Continue as ISO with non rfc5322 compliant email
	Given I'm an ISO
	And I'm requesting a Demo
	When I click in Submit wit non rfc5322 compliant email (non johndoe@example.xxx)
	Then I'll be prompted with an error 'Please ensure all values are in a proper format.' and fields with errors

Scenario: Continue as Strategic Partner with non rfc5322 compliant email
	Given I'm a Strategic Partner
	And I'm requesting a Demo
	When I click in Submit with non rfc5322 compliant email (non johndoe@example.xxx)
	Then I'll be prompted with an error 'Please ensure all values are in a proper format.' and fields with errors

Scenario: Continue as broker with non english format company phone number
	Given I'm a Broker
	And I'm requesting a Demo
	When I click in Submit with Company Phone Number with letters / numbers non conforming the english phone format
	Then I'll be prompted with an error 'Please ensure all values are in a proper format.' and fields with errors

Scenario: Continue as ISO with non english format phone number
	Given I'm an ISO
	And I'm requesting a Demo
	When I click in Submit with Company Phone Number with letters / numbers non conforming the english phone format
	Then I'll be prompted with an error 'Please ensure all values are in a proper format.' and fields with errors
```
