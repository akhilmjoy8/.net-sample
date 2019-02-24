using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleProject.Models
{
    public class LoginRepository
    {
        SampleProjectEntities dbContext = new SampleProjectEntities();        
               
        internal bool Register(tbl_Login model)
        {
            dbContext.AddTotbl_Login(model);
            dbContext.SaveChanges();
            return true;
        }
        internal List<tbl_Login> GetDetails()
        {
            return dbContext.tbl_Login.ToList();
        }
    }
}