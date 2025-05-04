using System.Text.Json.Serialization;

namespace HedwigNotificationSystem.Domain.User;

public class UserSignInUriDto
{
    [JsonPropertyName("id")]
    public Guid Id { get; set; }
    [JsonPropertyName("email")]
    public string Email { get; set; }
    [JsonPropertyName("passwordSetUri")]
    public string PasswordSetUri { get; set; }
    [JsonPropertyName("verificationEmailUri")]
    public string VerificationEmailUri { get; set; }
}
