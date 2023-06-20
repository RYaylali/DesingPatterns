using DP.ChainOfResponsibilty.DAL;
using DP.ChainOfResponsibilty.Models;

namespace DP.ChainOfResponsibilty.ChainOfResponsiblty
{
    public class Treasurer : Employee
    {
        public override void ProcessRequest(CustomerProcessVM request)
        {
            Context context = new Context();
            if (request.Amount<=100000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = request.Amount.ToString();
                customerProcess.Name = request.Name;
                customerProcess.EmployeeName = "Veznedar";
                customerProcess.Description = "Para Çekme İşlemi Onaylandı";
                context.Add(customerProcess);
                context.SaveChanges();
            }
            else if(NextApprover!= null) 
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = request.Amount.ToString();
                customerProcess.Name = request.Name;
                customerProcess.EmployeeName = "Veznedar";
                customerProcess.Description = "Para Çekme Veznedarın Ödeme Limitini Aştığı için Şube Müdür Yardımcısına Yönlendirildi";
                context.Add(customerProcess);
                context.SaveChanges();
                NextApprover.ProcessRequest(request);//Parametreden alınan değerleri diğerki kişiye yani şube müdür yardımcısına gönder
            }

        }
    }
}
