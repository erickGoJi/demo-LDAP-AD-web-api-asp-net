namespace demo_LDAP_AD_web_api_asp_net.Models;

public class LDAPAuthRequest
{
    public string DomainName { get; set; } = string.Empty;
    public string UserName { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
}