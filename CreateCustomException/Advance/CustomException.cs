using System;

namespace CreateCustomException.Advance
{
    class CustomGeneric<T> where T : class, new()
    {
        public T GetInstance()
        {
            return new T();
        }
    }

    class CustomException<T> : Exception where T : Exception, new()
    {
        public T GetInstance()
        {
            return new T();
        }
    }
}