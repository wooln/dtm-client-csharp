using System;

namespace DtmCommon
{
    public class DtmFailureException : DtmException
    {
        public DtmFailureException(string message = ErrFailure)
            : base(message)
        {
        }

        public DtmFailureException(string message, Exception innerException)
          : base(message, innerException)
        {
        }
    }
}