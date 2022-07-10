using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linux1230.Helper.Services.Response
{
    public class ServiceObjectResponse<T> : ServiceResponse
    {
        public T? Object { get; set; }

        public ServiceObjectResponse()
        {
            
        }

        public ServiceObjectResponse(T? obj, string? message, ServiceResponseState state) : 
            base(message, state)
        {
            Object = obj;
        }
    }
}
