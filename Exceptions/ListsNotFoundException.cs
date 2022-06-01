using System;
using TrelloCardsCounter.Models;

namespace TrelloCardsCounter.Exceptions;

[Serializable]
public class ListsNotFoundException: Exception
{
    private TrelloBoard? Board { get; }

    public ListsNotFoundException() { }

    public ListsNotFoundException(string? message) : base(message) { }

    public ListsNotFoundException(string? message, Exception? innerException) : base(message, innerException) { }

    public ListsNotFoundException(string? message, TrelloBoard board) : this(message)
    {
        this.Board = board;
    }
}
