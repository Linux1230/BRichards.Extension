﻿using System.Net.Mail;
using System.Text.RegularExpressions;

namespace BRichards.Helper.StringUtils;

public static class Validation
{
    /// <summary>
    /// Checks if a given e-mail is valid.
    /// </summary>
    /// <param name="emailAddress"></param>
    /// <returns></returns>
    public static bool EMailIsValid(string emailAddress) =>
        MailAddress.TryCreate(emailAddress, out _);

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

        const string pattern = @"^.*(?=.{8,})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!*@#$%^&+=]).*$";
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

        const string pattern = @"^(.+?)#\d{4}$";       
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

        const string pattern = @"^[0-9]{8}-[0-9]{8}(-[0-9]{8})?$";
        return Regex.Match(number, pattern).Success;
    }
}