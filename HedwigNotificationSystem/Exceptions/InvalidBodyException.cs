namespace HedwigNotificationSystem.Exceptions;

public class InvalidBodyException : Exception
{
    public InvalidBodyException() : base()
    {
    }

    public InvalidBodyException(string message) : base(message)
    {
    }

    public InvalidBodyException(string message, Exception innerException) : base(message, innerException)
    {
    }
}