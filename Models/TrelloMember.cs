using System.Collections.Generic;

namespace TrelloCardsCounter.Models;

public class TrelloMember
{
    public string? id;
    public string? aaId;
    public bool activityBlocked;
    public object? avatarHash;
    public object? avatarUrl;
    public string? bio;
    public object? bioData;
    public bool confirmed;
    public string? fullName;
    public object? idEnterprise;
    public List<object>? idEnterprisesDeactivated;
    public object? idMemberReferrer;
    public List<object>? idPremOrgsAdmin;
    public string? initials;
    public string? memberType;
    public NonPublic? nonPublic;
    public bool nonPublicAvailable;
    public List<object>? products;
    public string? url;
    public string? username;
    public string? status;
    public object? aaBlockSyncUntil;
    public object? aaEmail;
    public object? aaEnrolledDate;
    public string? avatarSource;
    public int credentialsRemovedCount;
    public object? domainClaimed;
    public string? email;
    public object? goldSunsetFreeTrialIdOrganization;
    public string? gravatarHash;
    public List<string>? idBoards;
    public List<string>? idOrganizations;
    public List<object>? idEnterprisesAdmin;
    public Limits? limits;
    public List<string>? loginTypes;
    public MarketingOptIn? marketingOptIn;
    public List<MessagesDismissed>? messagesDismissed;
    public List<string>? oneTimeMessagesDismissed;
    public Prefs? prefs;
    public List<object>? trophies;
    public object? uploadedAvatarHash;
    public object? uploadedAvatarUrl;
    public List<string>? premiumFeatures;
    public bool isAaMastered;
    public string? ixUpdate;

    public class NonPublic
    {
    }

    public class TotalPerMember
    {
        public string? status;
        public int disableAt;
        public int warnAt;
    }

    public class Boards
    {
        public TotalPerMember? totalPerMember;
    }

    public class Orgs
    {
        public TotalPerMember? totalPerMember;
    }

    public class Limits
    {
        public Boards? boards;
        public Orgs? orgs;
    }

    public class MarketingOptIn
    {
        public bool? optedIn;
        public string? date;
    }

    public class MessagesDismissed
    {
        public string? id;
        public string? name;
        public int count;
        public string? lastDismissed;
    }

    public class Privacy
    {
        public string? fullName;
        public string? avatar;
    }

    public class Prefs
    {
        public Privacy? privacy;
        public bool sendSummaries;
        public int minutesBetweenSummaries;
        public int minutesBeforeDeadlineToNotify;
        public bool colorBlind;
        public string? locale;
    }
}
