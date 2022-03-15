namespace PortalJob.BusinessLogic.Exceptions
{
    public class InternalErrorException : Exception
    {
        public InternalErrorException()
        {

        }

        public InternalErrorException(string message) : base(message)
        {

        }

        public InternalErrorException(string message, Exception exception) : base(message, exception)
        {

        }
    }
}
