using DP.ChainOfResponsibilty.DAL;
using DP.ChainOfResponsibilty.Models;

namespace DP.ChainOfResponsibilty.ChainOfResponsiblty
{
    public class Manager:Employee
    {
        public override void ProcessRequest(CustomerProcessVM request)
        {
            Context context = new Context();
            if (request.Amount <= 250000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = request.Amount.ToString();
                customerProcess.Name = request.Name;
                customerProcess.EmployeeName = "Şube Müdürü";
                customerProcess.Description = "Para Çekme İşlemi Onaylandı";
                context.Add(customerProcess);
                context.SaveChanges();
            }
            else if (NextApprover != null)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = request.Amount.ToString();
                customerProcess.Name = request.Name;
                customerProcess.EmployeeName = "Şube Müdürü";
                customerProcess.Description = "Para Çekme Şube Müdürü Ödeme Limitini Aştığı için Bölge Müdürüne Yönlendirildi";
                context.Add(customerProcess);
                context.SaveChanges();
                NextApprover.ProcessRequest(request);
            }

        }
    }
}
