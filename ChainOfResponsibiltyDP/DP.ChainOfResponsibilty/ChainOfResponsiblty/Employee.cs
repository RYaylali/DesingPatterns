using DP.ChainOfResponsibilty.DAL;
using DP.ChainOfResponsibilty.Models;

namespace DP.ChainOfResponsibilty.ChainOfResponsiblty
{
    public abstract class Employee
    {
        protected Employee NextApprover;//Önceki çalışandan gelen işlem
        public void SetNextApprover(Employee superVisor)//onaylanma 
        {
            this.NextApprover = superVisor;
        }
        public abstract void ProcessRequest(CustomerProcessVM request);//Parametre ile verileri alıp işlemek için
    }
}
