﻿namespace PortalJob.BusinessLogic.Exceptions
{
    public class BadRequestException : Exception
    {
        public BadRequestException()
        {

        }

        public BadRequestException(string message) : base(message)
        {

        }

        public BadRequestException(string message, Exception exception) : base(message, exception)
        {

        }
    }
}
