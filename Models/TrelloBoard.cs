using System.Collections.Generic;

namespace TrelloCardsCounter.Models;

public class TrelloBoard
{
    public string? id;
    public string? name;
    public string? desc;
    public object? descData;
    public bool closed;
    public object? dateClosed;
    public string? idOrganization;
    public object? idEnterprise;
    public object? limits;
    public object? pinned;
    public bool starred;
    public string? url;
    public Prefs? prefs;
    public string? shortLink;
    public bool subscribed;
    public LabelNames? labelNames;
    public List<object>? powerUps;
    public string? dateLastActivity;
    public string? dateLastView;
    public string? shortUrl;
    public List<object>? idTags;
    public object? datePluginDisable;
    public string? creationMethod;
    public object? ixUpdate;
    public object? templateGallery;
    public bool enterpriseOwned;
    public object? idBoardSource;
    public List<string>? premiumFeatures;
    public string? idMemberCreator;
    public List<Membership>? memberships;

    public class BackgroundImageScaled
    {
        public int width;
        public int height;
        public string? url;
    }

    public class Prefs
    {
        public string? permissionLevel;
        public bool hideVotes;
        public string? voting;
        public string? comments;
        public string? invitations;
        public bool selfJoin;
        public bool cardCovers;
        public bool isTemplate;
        public string? cardAging;
        public bool calendarFeedEnabled;
        public List<object>? hiddenPluginBoardButtons;
        public string? background;
        public string? backgroundColor;
        public string? backgroundImage;
        public List<BackgroundImageScaled>? backgroundImageScaled;
        public bool backgroundTile;
        public string? backgroundBrightness;
        public string? backgroundBottomColor;
        public string? backgroundTopColor;
        public bool canBePublic;
        public bool canBeEnterprise;
        public bool canBeOrg;
        public bool canBePrivate;
        public bool canInvite;
    }

    public class LabelNames
    {
        public string? green;
        public string? yellow;
        public string? orange;
        public string? red;
        public string? purple;
        public string? blue;
        public string? sky;
        public string? lime;
        public string? pink;
        public string? black;
    }

    public class Membership
    {
        public string? idMember;
        public string? memberType;
        public bool unconfirmed;
        public bool deactivated;
        public string? id;
    }
}
