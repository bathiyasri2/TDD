using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.Tests.Business
{
    public class AdjenHelper : IBaseRules,IAdyenRules
    {

        
        public bool ValidataData()
        {
            return true;
        }

        public bool ValidateCustomerName()
        {
            throw new NotImplementedException();
        }

        public bool ValidateCustomerNameLength()
        {
            throw new NotImplementedException();
        }
    }

    public interface IBaseRules
    {
         bool ValidataData();
    }


    public interface IAdyenRules
    {
        bool ValidateCustomerName();
        bool ValidateCustomerNameLength();
        


    }
}
