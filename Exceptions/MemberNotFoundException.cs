using System;
using System.Runtime.Serialization;

namespace TrelloCardsCounter.Exceptions;

[Serializable]
public class MemberNotFoundException: Exception
{
    public MemberNotFoundException() { }

    public MemberNotFoundException(string? message) : base(message) { }

    protected MemberNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context) { }

    public MemberNotFoundException(string? message, Exception? innerException) : base(message, innerException) { }
}
