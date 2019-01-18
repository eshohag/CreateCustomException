using System;

namespace CreateCustomException
{
    [Serializable]
    class TempIsZeroException : Exception
    {
        public TempIsZeroException(string message) : base(message)
        {
        }

        public TempIsZeroException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}