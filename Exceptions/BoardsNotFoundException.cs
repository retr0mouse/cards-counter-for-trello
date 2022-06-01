using System;
using TrelloCardsCounter.Models;

namespace TrelloCardsCounter.Exceptions;

[Serializable]
public class BoardsNotFoundException: Exception
{
    private TrelloMember? Member { get; }
    
    public BoardsNotFoundException() { }
    
    public BoardsNotFoundException(string? message) : base(message) { }

    public BoardsNotFoundException(string? message, Exception? innerException) : base(message, innerException) { }

    public BoardsNotFoundException(string? message, TrelloMember member): this(message)
    {
        this.Member = member;
    }
}
