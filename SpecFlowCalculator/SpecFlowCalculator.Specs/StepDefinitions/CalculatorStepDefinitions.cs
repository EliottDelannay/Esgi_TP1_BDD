using FluentAssertions;
using NUnit.Framework;
using TechTalk.SpecFlow;
namespace SpecFlowCalculator.Specs.StepDefinitions
{
    
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        private readonly Calculator _calculator = new Calculator();
        private int _result;
        private Exception _exception;

        /* old methods
        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
             _calculator.FirstNumber = number
        }
        
        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            _calculator.SecondNumber = number
        }*/

        [Given("the Number is (.*)")]
        public void GivenTheNumberIs(int number)
        {
            _calculator.Numbers.Add(number);
        }
        
        [Given("the Opperator is (.*)")]
        public void GivenTheOperatorIs(char Opperator)
        {
            _calculator.Operators.Add(Opperator);
        }
        
        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            _result = _calculator.Add();
        }

        [When("the two numbers are divided")]
        public void WhenTheTwoNumbersAreDivided()
        {
            try
            {
                _result = _calculator.divide();
            }
            catch(Exception e)
            {
                _exception = e;
            }         
        }

        [When("the two numbers are multiplied")]
        public void WhenTheTwoNumbersAreMultiplied()
        {
            _result = _calculator.multiply();
        }

        [When("the numbers are added")]
        public void WhenTheNumbersAreAdded()
        {
            _result = _calculator.Add();
        }

        [When("the numbers are divided")]
        public void WhenTheNumbersAreDivided()
        {
            try
            {
                _result = _calculator.divide();
            }
            catch (Exception e)
            {
                _exception = e;
            }
        }

        [When("the numbers are multiplied")]
        public void WhenTheNumbersAreMultiplied()
        {
            _result = _calculator.multiply();
        }

        [When("they are multiples operand")]
        public void WhenMultiplesOperand()
        {
            _result = _calculator.Operation();
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            _result.Should().Be(result);
        }

        [Then("the error should be (.*)")]
        public void ThenTheErrorShouldBe(string expectedErrorMessage)
        {
            Assert.AreEqual(expectedErrorMessage, _exception.Message);
        }

    }
}