# Cards counter in Trello lists

When keeping track of something using [Trello](https://trello.com), it might be useful to know the number of cards in some specific lists, for example when tracking books read each year. This simple console application resolves this problem.

## How it works
Essentially, the application is looking for a list with a name that is only 4 digits long, i.e. year. It then counts all the cards in the list and changes its title, for example, from "2022" to "2022 (12)", where 12 is the number of cards in it.


## Prerequisite
Make sure to create a `Trello Api token and key` in order to use this app. Current version does not have an input to enter credentials, so in order to start the application, it is necessary to insert them right into the `TrelloApi class` as shown here:
```c#
public class TrelloApi
{
    private const string TrelloKey = "asdf1234asdf1234asf1234asdf1234";    // insert credentials
    private const string TrelloToken = "asdf1234asdf12324asdf1234sadf1234";// here
    .......
}
```