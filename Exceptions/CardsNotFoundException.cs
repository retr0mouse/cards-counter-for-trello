using System;
using TrelloCardsCounter.Models;

namespace TrelloCardsCounter.Exceptions;

[Serializable]
public class CardsNotFoundException: Exception
{
    private TrelloBoard? Board { get; }

    public CardsNotFoundException() { }

    public CardsNotFoundException(string? message) : base(message) { }

    public CardsNotFoundException(string? message, Exception? innerException) : base(message, innerException) { }

    public CardsNotFoundException(string? message, TrelloBoard board) : this(message)
    {
        this.Board = board;
    }
}
