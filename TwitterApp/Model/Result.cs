using System;

namespace TwitterApp.Model
{
    public delegate void ResultCallback<T>(Result<T> result);

    public class Result<T>
    {
        public Result(T value)
        {
            Value = value;
        }

        public Result(Exception exception)
        {
            Exception = exception;
        }

        public T Value { get; private set; }
        public Exception Exception { get; private set; }

        public bool HasValue()
        {
            return Value != null;
        }

        public bool HasError()
        {
            return Exception != null;
        }
    }
}