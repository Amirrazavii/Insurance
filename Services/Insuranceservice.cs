using Insurance.Models;

namespace Insurance.Services
{
    public class Insuranceservice : IInsuranceservice
    {

        InsuranceContext  db_context=new InsuranceContext();
        public List<HistoryInsurance> create(int IdUser, List<HistoryInsurance> insurance)
        {
            foreach( HistoryInsurance i in insurance){
            using(HistoryInsurance createinsurance=new HistoryInsurance())
            {
            int addad = Convert.ToInt32(i.number);
            
            if(i.Name=="jarahi" && 5000<addad && addad < 5000000000){

               createinsurance.Name=i.Name;
               createinsurance.number=i.number;
               createinsurance.Percent=0.0052;
               createinsurance.UserId=IdUser;


            }
            else if(i.Name=="dandanpezeshki" && 4000<addad && addad < 4000000000)
            {
               createinsurance.Name=i.Name;
               createinsurance.number=i.number;
               createinsurance.Percent=0.0042;
               createinsurance.UserId=IdUser;
            }else if(i.Name=="bastari" && 2000<addad && addad < 2000000000){
               createinsurance.Name=i.Name;
               createinsurance.number=i.number;
               createinsurance.Percent=0.005;
               createinsurance.UserId=IdUser;
            }
            db_context.Add(createinsurance);

            db_context.SaveChanges();

            }}

        return getalluserinsurance(IdUser);


            
        }



      public List<HistoryInsurance> getalluserinsurance(int IdUser)
        {
            List<HistoryInsurance> insuranceuser =(List<HistoryInsurance>)db_context.HistoryInsurances.Where(x=>x.UserId == IdUser);

           return insuranceuser;
        }


    }
}