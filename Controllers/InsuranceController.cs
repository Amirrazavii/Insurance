using Insurance.Models;
using Insurance.Services;
using Microsoft.AspNetCore.Mvc;

namespace Insurance.Controllers
{
    
    
    [ApiController]
    [Route("Api/[controller]")]
    public class InsuranceControllers:ControllerBase
    {
     Insuranceservice instanceInsurance=new Insuranceservice();

        [HttpPost("id")]
        public List<HistoryInsurance> create(int id,List<HistoryInsurance> body)
        {
            return instanceInsurance.create(id,body);
        }

        
    }
}