using DP.ChainOfResponsibilty.DAL;
using DP.ChainOfResponsibilty.Models;

namespace DP.ChainOfResponsibilty.ChainOfResponsiblty
{
    public class ManagerAssistant :Employee
    {
        public override void ProcessRequest(CustomerProcessVM request)
        {
            Context context = new Context();
            if (request.Amount <= 150000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = request.Amount.ToString();
                customerProcess.Name = request.Name;
                customerProcess.EmployeeName = "Şube Müdür Yardımcısı";
                customerProcess.Description = "Para Çekme İşlemi Onaylandı";
                context.Add(customerProcess);
                context.SaveChanges();
            }
            else if (NextApprover != null)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = request.Amount.ToString();
                customerProcess.Name = request.Name;
                customerProcess.EmployeeName = "Şube Müdür Yardımcısı";
                customerProcess.Description = "Para Çekme Şube Müdür Yardımcısı Ödeme Limitini Aştığı için Şube Müdürüne Yönlendirildi";
                context.Add(customerProcess);
                context.SaveChanges();
                NextApprover.ProcessRequest(request);//Parametreden alınan değerleri diğerki kişiye yani şube müdürüne yönlenecek gönder
            }

        }
    }
}
