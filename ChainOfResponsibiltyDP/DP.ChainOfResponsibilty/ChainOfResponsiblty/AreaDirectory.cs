using DP.ChainOfResponsibilty.DAL;
using DP.ChainOfResponsibilty.Models;

namespace DP.ChainOfResponsibilty.ChainOfResponsiblty
{
    public class AreaDirectory:Employee
    {
        public override void ProcessRequest(CustomerProcessVM request)
        {
            Context context = new Context();
            if (request.Amount <= 400000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = request.Amount.ToString();
                customerProcess.Name = request.Name;
                customerProcess.EmployeeName = "Bölge Müdürü";
                customerProcess.Description = "Para Çekme İşlemi Onaylandı";
                context.Add(customerProcess);
                context.SaveChanges();
            }
            else
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = request.Amount.ToString();
                customerProcess.Name = request.Name;
                customerProcess.EmployeeName = "Bölge Müdürü";
                customerProcess.Description = "Para Çekme Bölge Müdürü Ödeme Limitini Aştığı için İşlem Gerçekleşemedi";
                context.Add(customerProcess);
                context.SaveChanges();//son onayllayıcı sınıf olduğu için nextprovier yok
            }

        }
    }
}
