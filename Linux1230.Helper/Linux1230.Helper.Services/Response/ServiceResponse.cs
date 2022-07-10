using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linux1230.Helper.Services.Response
{
    public class ServiceResponse
    {
        public enum ServiceResponseState
        {
            Success = 0,
            Error = 1,
            Empty = 2,
            Invalid = 3
        }

        public string? Message { get; set; }
        public ServiceResponseState State { get; set; }

        public ServiceResponse()
        {
            
        }

        public ServiceResponse(string? message, ServiceResponseState state)
        {
            Message = message;
            State = state;
        }
    }
}
