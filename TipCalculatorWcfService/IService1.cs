using System.ServiceModel;

namespace TipCalculatorWcfService
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        double CalculateTip(double billAmount, int numPeople, double tipPercent);

        [OperationContract]
        double CalculateTotalWithTip(double billAmount, int numPeople, double tipPercent);

        [OperationContract]
        double CalculateTotalPerPerson(double billAmount, int numPeople, double tipPercent);
    }
}
