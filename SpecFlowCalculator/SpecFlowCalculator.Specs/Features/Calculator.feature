Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowCalculator.Specs/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: Add two numbers
	Given the Number is 50
	And the Number is 70
	When the two numbers are added
	Then the result should be 120

Scenario: Multiply two numbers
	Given the Number is 10
	And the Number is 5
	When the two numbers are multiplied
	Then the result should be 50

Scenario: Divide two numbers
	Given the Number is 22
	And the Number is 11
	When the two numbers are divided
	Then the result should be 2

Scenario: Divide by 0
	Given the Number is 1
	And the Number is 0
	When the two numbers are divided
	Then the error should be impossible to divide per zero

Scenario: Add X numbers
	Given the Number is 10
	And the Number is 150
	And the Number is 40
	When the numbers are added
	Then the result should be 200

Scenario: multiply X numbers
	Given the Number is 10
	And the Number is 5
	And the Number is 2
	When the numbers are multiplied
	Then the result should be 100

Scenario: Divide X numbers
	Given the Number is 150
	And the Number is 15
	And the Number is 10
	When the numbers are divided
	Then the result should be 1


Scenario: operation1
	Given the Number is 10
	And the Opperator is *
	And the Number is 5
	When they are multiples operand 
	Then the result should be 50


Scenario: operation2
	Given the Number is 10
	And the Opperator is *
	And the Number is 5
	And the Number is 2
	And the Opperator is /
	When they are multiples operand 
	Then the result should be 25