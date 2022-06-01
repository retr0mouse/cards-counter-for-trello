using System.Diagnostics.CodeAnalysis;

namespace TrelloCardsCounter;

public static class Safety
{
    public static bool IsNotNull([NotNullWhen(true)] object? obj) => obj != null;
}
