using System;
using System.Net.Http;
using System.Reflection.Metadata;
using System.Text.Json;
using System.Web;
using TrelloCardsCounter.Exceptions;
using TrelloCardsCounter.Models;

namespace TrelloCardsCounter;

public class TrelloApi
{
    private const string TrelloKey = "";    // insert credentials
    private const string TrelloToken = "";  // here

    private T? MakeApiRequest<T>(string requestUrl, string method)
    {
        using var httpClient = new HttpClient();
        if (method == "GET")
        {
            var result = httpClient.GetStringAsync(requestUrl).Result;
            var options = new JsonSerializerOptions {IncludeFields = true};
            return JsonSerializer.Deserialize<T>(result, options);
        }

        if (method == "PUT")
        {
            httpClient.PutAsync(requestUrl, null).Wait();
            return default;
        }

        throw new Exception("unknown method :" + method);
    }

    public TrelloMember GetMember()
    {
        var member = MakeApiRequest<TrelloMember>(
            $"https://api.trello.com/1/tokens/{TrelloToken}/member?key={TrelloKey}",
            "GET"
        );
        if (Safety.IsNotNull(member))
        {
            return member;
        }
        throw new MemberNotFoundException("No member found");
    }

    public TrelloBoard[] GetBoards(string memberId)
    {
        var boards = MakeApiRequest<TrelloBoard[]>(
            $"https://api.trello.com/1/members/{memberId}/boards?key={TrelloKey}&token={TrelloToken}",
            "GET");
        if (Safety.IsNotNull(boards))
        {
            return boards;
        }
        throw new BoardsNotFoundException("No boards found for member");
    }

    public TrelloCard[] GetCards(string boardId)
    {
        var cards = MakeApiRequest<TrelloCard[]>(
            $"https://api.trello.com/1/boards/{boardId}/cards?key={TrelloKey}&token={TrelloToken}",
            "GET"
        );
        if (Safety.IsNotNull(cards))
        {
            return cards;
        }

        throw new CardsNotFoundException("No cards found for this board");
    }

    public TrelloCard[] GetCardsInList(string listId)
    {
        var cards = MakeApiRequest<TrelloCard[]>(
            $"https://api.trello.com/1/lists/{listId}/cards?key={TrelloKey}&token={TrelloToken}",
            "GET"
        );
        if (Safety.IsNotNull(cards))
        {
            return cards;
        }

        throw new CardsNotFoundException("No cards found for this list");
    }

    public TrelloList[] GetLists(string boardId)
    {
        var lists = MakeApiRequest<TrelloList[]>(
            $"https://api.trello.com/1/boards/{boardId}/lists?key={TrelloKey}&token={TrelloToken}",
            "GET"
        );
        if (Safety.IsNotNull(lists))
        {
            return lists;
        }

        throw new ListsNotFoundException("No lists found for this board");
    }

    public void RenameList(string listId, string name)
    {
        name = HttpUtility.UrlEncode(name);
        MakeApiRequest<object>(
            $"https://api.trello.com/1/lists/{listId}?key={TrelloKey}&token={TrelloToken}&name={name}",
            "PUT"
        );
    }
}