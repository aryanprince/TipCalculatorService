namespace TipCalculatorWcfService
{
    public class Service1 : IService1
    {
        public double CalculateTip(double billAmount, int numPeople, double tipPercent)
        {
            // Calculate the tip
            return billAmount * (tipPercent / 100);
        }

        public double CalculateTotalWithTip(double billAmount, int numPeople, double tipPercent)
        {
            // Adds the tip to the bill amount
            return billAmount + (billAmount * (tipPercent / 100));
        }

        public double CalculateTotalPerPerson(double billAmount, int numPeople, double tipPercent)
        {
            // Adds the tip to the bill amount and divides this total by the number of people
            return (billAmount + (billAmount * tipPercent / 100)) / numPeople;
        }
    }
}
