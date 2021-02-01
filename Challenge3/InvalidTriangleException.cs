using System;
using System.Runtime.Serialization;

namespace Challenge3
{
    [Serializable]
    public class InvalidTriangleException : Exception
    {
        public InvalidTriangleException()
        {
        }

        public InvalidTriangleException(string message) : base(message)
        {
        }

        public InvalidTriangleException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidTriangleException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}