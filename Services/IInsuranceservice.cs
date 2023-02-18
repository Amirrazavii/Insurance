using Insurance.Models;

namespace Insurance.Services
{
    public interface IInsuranceservice
    {

        public List<HistoryInsurance> create(int IdUser,List<HistoryInsurance> insurance);

        public List<HistoryInsurance> getalluserinsurance(int IdUser);

 

       

         
    }
}