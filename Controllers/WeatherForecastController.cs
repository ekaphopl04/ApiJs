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

        private string Bmicaculater(double Bmitotal)
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
        //เกิดErrorขึ้นเนื่องจาก ไม่ใส่ค่าในพารามิเตอร์
        [HttpPost()]
        public BmiAndDes GetBmi(){
            
            BmiApi Bmi = new BmiApi();
            double Bmitotal = Bmi.Weight / ((Bmi.Height/100.0) * (Bmi.Height/100.0)) ;
            var Quality = Bmicaculater(Bmitotal);
            return  new BmiAndDes {
                  Bmi = Bmitotal,
                  Des = Quality 
            };//"ดัชนี้มวลกลายของคุณ คือ " + Bmitotal + "คุณ "+ Quality ;
        }
        //แก้โดยการส่งค่ากลับเป็นคลาส แต่อย่าลืมรับค่าสองตัวได้แก่ Weight Height
        [HttpPost()]
        public BmiAndDes GetBmi2(BmiApi Bmi){
            
            double Bmitotal = Bmi.Weight / ((Bmi.Height/100.0) * (Bmi.Height/100.0)) ;
            var Quality = Bmicaculater(Bmitotal);
            return    new BmiAndDes {
                  Bmi = Bmitotal,
                  Des = Quality 
            };//"ดัชนี้มวลกลายของคุณ คือ " + Bmitotal + "คุณ "+ Quality ;
        }

        


       
       
    }
}
