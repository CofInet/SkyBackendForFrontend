
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using Coflnet.Sky.Filter;
using Coflnet.Sky.Core;

namespace Coflnet.Sky.Commands.Shared;

public class CurrentEventDetailedFlipFilter : DetailedFlipFilter
{
    public enum Events
    {
        None,
        TravelingZoo,
        SpookyFestival,
        DarkAuction,
        NewYear,
        SeasonOfJerry
    }
    public enum Months
    {
        EarlySpring,
        Spring,
        LateSpring,
        EarlySummer,
        Summer,
        LateSummer,
        EarlyAutumn,
        Autumn,
        LateAutumn,
        EarlyWinter,
        Winter,
        LateWinter
    }
    public object[] Options => Enum.GetValues(typeof(Events)).Cast<object>().ToArray();

    public FilterType FilterType => FilterType.Equal;
    protected virtual DateTime Now => DateTime.UtcNow;

    public Expression<Func<FlipInstance, bool>> GetExpression(Dictionary<string, string> filters, string val)
    {
        var eventVal = (Events)Enum.Parse(typeof(Events), val);
        var currentDay = GetCurrentDay();
        var eventList = new List<(int, int, Events)>()
        {
            (12*31-3,12*31, Events.NewYear),
            (03*31,03*31+3, Events.TravelingZoo),
            (9*31,9*31+3, Events.TravelingZoo),
            ((int)Months.Autumn*31+28,(int)Months.LateAutumn*31, Events.SpookyFestival),
            (11*31+23,11*31+26, Events.SeasonOfJerry)
        };
        var currentEvent = eventList.FirstOrDefault(e => currentDay >= e.Item1 && currentDay <= e.Item2).Item3;

        return a => currentEvent == eventVal;
    }

    private int GetCurrentDay()
    {
        return (int)(Constants.SkyblockYear(Now) * 31 * 12) % (31 * 12);
    }
}
