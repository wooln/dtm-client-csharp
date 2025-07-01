using System;

namespace DtmCommon
{
    public class DtmException : Exception
    {
        public DtmException(string message)
            : base(message)
        {
        }

        public DtmException(string message, Exception innerException)
           : base(message, innerException)
        {
        }

        public const string ErrFailure = "FAILURE";
        public const string ErrOngoing = "ONGOING";
        public const string ErrDuplicated = "DUPLICATED";
    }
}