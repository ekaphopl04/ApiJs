using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BmiJs.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class BmiJsController : ControllerBase
    {

        public string Bmicaculater(float Bmitotal)
        {
            if(Bmitotal>24.9)
            {
                return "อ้วนมาก" ;
            }
             if(Bmitotal>22.9)
            {
                return "อ้วน" ;
            }
             if(Bmitotal>18.5)
            {
                return "น้ำหนักปกติ" ;
            }
             else
            {
                return "ผอมเกินไป" ;
            }

        }
        [HttpPost()]
        public string GetBmi(BmiApi Bmi){
            var Bmitotal = Bmi.Weight / ((Bmi.Height/100)*(Bmi.Height/100));
            var Quality = Bmicaculater(Bmitotal);
            return "ดัชนี้มวลกลายของคุณ คือ " + Bmitotal + "คุณ "+ Quality ;


        }


       
       
    }
}
