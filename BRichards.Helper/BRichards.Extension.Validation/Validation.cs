using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace BRichards.Extension.Validation;

public static class Validation
{
    /// <summary>
    /// Mirrors string.IsNullOrWhiteSpace(string? value)
    /// </summary>
    /// <param name="value"></param>
    /// <returns>bool</returns>
    public static bool IsNullOrWhiteSpace(this string? value) =>
        string.IsNullOrWhiteSpace(value);

    public static bool IsValidUri(this string uri) =>
        Uri.TryCreate(uri, UriKind.Absolute, out var outUri)
            && (outUri.Scheme == Uri.UriSchemeHttp || outUri.Scheme == Uri.UriSchemeHttps);

    /// <summary>
    /// Checks if a given e-mail is valid.
    /// </summary>
    /// <param name="address"></param>
    /// <returns></returns>
    public static bool IsValidEmailAddress(this string address) =>
        new EmailAddressAttribute().IsValid(address ?? throw new ArgumentNullException(nameof(address)));


    /// <summary>
    /// Checks is a given password is valid.
    /// Password is valid when it has:
    /// At least one lower case letter,
    /// At least one upper case letter,
    /// At least one special character,
    /// At least one number,
    /// At least 8 characters
    /// </summary>
    /// <param name="password"></param>
    /// <param name="userName"></param>
    /// <returns>bool</returns>
    public static bool PasswordIsValid(string password, string userName)
    {
        if (!string.IsNullOrWhiteSpace(password) ||
            !string.IsNullOrWhiteSpace(userName) ||
            password.Contains(userName))
        {
            return false;
        }

        const string pattern = /*lang=regex*/@"^.*(?=.{8,})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!*@#$%^&+=]).*$";
        return Regex.Match(password, pattern).Success;
    }

    /// <summary>
    /// Checks if the given is is a valid Discord name
    /// Discord name is valid when in this format:
    /// [Any char, except line break]#[4 digit char]
    /// </summary>
    /// <param name="discord"></param>
    /// <returns>bool</returns>
    public static bool DiscordIsValid(string discord)
    {
        if (!string.IsNullOrWhiteSpace(discord))
        {
            return false;
        }

        const string pattern = /*lang=regex*/@"^(.+?)#\d{4}$";
        return Regex.Match(discord, pattern).Success;
    }

    /// <summary>
    /// Checks if a Hungarian Account Number Is Valid
    /// </summary>
    /// <param name="number"></param>
    /// <returns>bool</returns>
    public static bool HungarianAccountNumberIsValid(string number)
    {
        if (!string.IsNullOrWhiteSpace(number))
        {
            return false;
        }

        const string pattern = /*lang=regex*/@"^[0-9]{8}-[0-9]{8}(-[0-9]{8})?$";
        return Regex.Match(number, pattern).Success;
    }
}
