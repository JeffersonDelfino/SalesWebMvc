using SalesWebMvc.Services;
using System;
using System.Threading.Tasks;

namespace SalesWebMvc.Controllers
{
    internal class SalesRecordServices
    {
        public static implicit operator SalesRecordServices(SalesRecordService v)
        {
            throw new NotImplementedException();
        }

        internal Task FindByDateAsync(DateTime? minDate, DateTime? maxDate)
        {
            throw new NotImplementedException();
        }
    }
}