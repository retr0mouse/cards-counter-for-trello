using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;
using System.Threading;
using TrelloCardsCounter.Models;

namespace TrelloCardsCounter;

internal static class Program
{
    public static void Main()
    {
        while (true)
        {
            var api = new TrelloApi();
            var member = api.GetMember();
            if (!Safety.IsNotNull(member.id)) break;
            var boards = api.GetBoards(member.id);
            foreach (var board in boards)
            {
                if (!Safety.IsNotNull(board.id)) break;
                var lists = api.GetLists(board.id);
                foreach (var list in lists)
                {
                    var regex = new Regex("^\\d{4}");
                    if (!Safety.IsNotNull(list.name)) continue;
                    var matchFound = regex.IsMatch(list.name);
                    if (!matchFound || !Safety.IsNotNull(list.id)) continue;
                    var cards = api.GetCardsInList(list.id);
                    list.name = list.name[..4] + " (" + cards.Length + ")";
                    api.RenameList(list.id, list.name);
                }
            }
            Console.WriteLine("Done");
            Thread.Sleep(TimeSpan.FromHours(1));
        }
    }
}