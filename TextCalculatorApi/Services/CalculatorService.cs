namespace TextCalculatorApi;

public class CalculatorService
{
    public string Add(string number)
    {
        if (string.IsNullOrWhiteSpace(number))
        {
            return "0";
        }

        if (number.EndsWith(",") || number.StartsWith(","))
        {
            throw new InvalidOperationException("Missing number in the input.");
        }

        var numArray = number.Split(',').Select(n => Convert.ToDecimal(n)).ToArray();
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

