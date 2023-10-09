using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Coflnet.Sky.Api.Models.Mod;

/// <summary>
/// List of available fields
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum DescriptionField
{
    /// <summary>
    /// Display nothing (global)
    /// </summary>
    NONE,
    /// <summary>
    /// Display the lowest bin
    /// </summary>
    LBIN,
    /// <summary>
    /// Display the key used to get the lowest bin
    /// </summary>
    LBIN_KEY,
    /// <summary>
    /// Display the median price
    /// </summary>
    MEDIAN,
    /// <summary>
    /// Display the key used to get the median price
    /// </summary>
    MEDIAN_KEY,
    /// <summary>
    /// Display the volume
    /// </summary>
    VOLUME,
    /// <summary>
    /// Display the item tag
    /// </summary>
    TAG,
    /// <summary>
    /// Display the craft cost
    /// </summary>
    CRAFT_COST,
    /// <summary>
    /// Display the bazaar buy cost
    /// </summary>
    BazaarBuy,
    /// <summary>
    /// Display the bazaar sell profit
    /// </summary>
    BazaarSell,
    /// <summary>
    /// Display price paid
    /// </summary>
    PRICE_PAID,
    /// <summary>
    /// Breakdown of relevant price modifying stats
    /// </summary>
    ITEM_KEY,
    /// <summary>
    /// Enchant Cost Summary
    /// </summary>
    EnchantCost,
    /// <summary>
    /// Sum of gemstone value
    /// </summary>
    GemValue,
    /// <summary>
    /// Summary of past list attempts
    /// </summary>
    SpentOnAhFees,
    /// <summary>
    /// how much kat takes in coins and materials to upgrade
    /// </summary>
    KatUpgradeCost,
    // anything over 9000 gets hidden
    BAZAAR_COST = 9001
}
