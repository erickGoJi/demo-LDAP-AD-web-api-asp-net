using System.DirectoryServices;
using System.Runtime.Versioning;

namespace demo_LDAP_AD_web_api_asp_net.Extensions;

public static class ADExtensionMethods
{
    [SupportedOSPlatform("windows")]
    public static string? GetPropertyValue(this SearchResult searchResult, string propertyName)
    {
        var propertyValueCollection = searchResult.Properties[propertyName];

        if (propertyValueCollection.Count <= 0) return null;

        return propertyValueCollection[0]?.ToString();
    }
}