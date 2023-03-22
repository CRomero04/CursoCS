using System.Runtime.Serialization;

namespace ConceptoCS
{
    [Serializable]
    internal class MouthException : Exception
    {
        public MouthException()
        {
        }

        public MouthException(string? message) : base(message)
        {
        }

        public MouthException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected MouthException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}