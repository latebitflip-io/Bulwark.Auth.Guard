using System;

namespace Bulwark.Auth.Guard.Exceptions;

public class BulwarkTokenExpiredException : Exception
{
    public BulwarkTokenExpiredException(string message) :
        base(message) { }

    public BulwarkTokenExpiredException(string message, Exception inner) :
        base(message, inner) { }
}