
namespace TextCalculatorWebApp.Models
{
	public class CalculatorModel
	{
		public string number { get; set; }
		public string result { get; set; }

		public CalculatorModel(string number)
		{
			this.number = number;
		}
	}
}

