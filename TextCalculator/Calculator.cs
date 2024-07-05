namespace TextCalculator
{
	public class Calculator
	{
        public string Add(string number)
        {
            /* 
            1) Take numbers separated by commas
            2) "" Empty string -> "0"
            3) "1,3," is invalid
            4) "-1,2" is invalid
            5) Return string sum
            */

            if (string.IsNullOrWhiteSpace(number))
            {
                return "0";
            }

            if (number.EndsWith(",") || number.StartsWith(","))
            {
                throw new InvalidOperationException("Missing number in the input.");
            }

            // var numArray = number.Split(',').Select(n => Convert.ToDecimal(n)).ToArray();
            var numArray = number.Split(',').Select(Convert.ToDecimal);
            decimal sum = 0;
            string negativeString = "";

            foreach (decimal num in numArray)
            {
                if (num < 0)
                {
                    negativeString += num.ToString() + ", ";
                }
                else
                {
                    sum += num;
                }
            }

            if (negativeString.Length > 0) 
            {
                throw new InvalidOperationException("Negative not allowed: " + negativeString.Substring(0, negativeString.Length - 2));
            }

            if (sum % 1 == 0)
            {
                return Convert.ToInt32(sum).ToString();
            }

            return sum.ToString();
        }
    }
}

