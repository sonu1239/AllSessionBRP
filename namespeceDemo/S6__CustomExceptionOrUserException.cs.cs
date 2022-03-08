using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllSession
{
    class S6__CustomExceptionOrUserException: Exception

    {

        public enum UserException
        {
            INVALID_DATA, INVALID_VALUE
        }
        private readonly UserException Type;
        public S6__CustomExceptionOrUserException(UserException Type, string Message) : base(Message)
        {
            this.Type = Type;
        }

    }
}
