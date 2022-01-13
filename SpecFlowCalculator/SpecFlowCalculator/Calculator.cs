namespace SpecFlowCalculator
{
    public class Calculator
    {
        //simple operation
        //public int FirstNumber { get; set; }
        //public int SecondNumber { get; set; }

        public int result { get; set; }
        public List<int> Numbers = new List<int>();
        public List<char> Operators = new List<char>();

        /* add with 2 numbers
        public int Add()
        {
            return FirstNumber + SecondNumber;
        }
        */

        public int Add()
        {
            foreach (Object i in Numbers)
            {
                result += (int)i;
            }
            return result;
        }

        public int multiply()
        {
            result = Numbers[0];
            for (int i = 1; i < Numbers.Count; i++)
            {
                result = result * Numbers[i];
            }
            return result;
        }
        public int divide()
        {
            result = Numbers[0];
            try
            {
                for (int i = 1; i < Numbers.Count; i++)
                {
                    result = result / Numbers[i];
                }
            }
            catch (DivideByZeroException)
            {
                throw new InvalidOperationException("impossible to divide per zero");
            }

            return result;
        }

        public int Operation()
        {
            result = Numbers[0];
            try
            {
                for (int i = 0; i < Operators.Count; i++)
                {
                    switch (Operators[i])
                    {
                        case '+' :
                            result = result + Numbers[i+1];
                            break;
                        case '*' :
                            result = result * Numbers[i+1];
                            break;
                        case '/' :
                            result = result / Numbers[i+1];
                            break;
                    }
                }
                return result;
            }
            catch (DivideByZeroException)
            {
                throw new InvalidOperationException("impossible to divide per zero");
            }
           
        }
    }
}