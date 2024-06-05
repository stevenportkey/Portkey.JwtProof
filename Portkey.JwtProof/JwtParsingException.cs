namespace Portkey.JwtProof;

public class JwtParsingException : Exception
{
    public JwtParsingException()
    {
    }

    public JwtParsingException(string message)
        : base(message)
    {
    }

    public JwtParsingException(string message, Exception inner)
        : base(message, inner)
    {
    }
}