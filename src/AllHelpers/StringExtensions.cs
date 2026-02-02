namespace AllHelpers.Extensions;

/// <summary>
/// Extension methods for string manipulation
/// </summary>
public static class StringExtensions
{
    /// <summary>
    /// Truncates a string to the specified length and adds ellipsis if truncated
    /// </summary>
    /// <param name="value">The string to truncate</param>
    /// <param name="maxLength">Maximum length of the string</param>
    /// <param name="ellipsis">The ellipsis string to append (default: "...")</param>
    /// <returns>Truncated string with ellipsis if needed</returns>
    public static string Truncate(this string value, int maxLength, string ellipsis = "...")
    {
        if (string.IsNullOrEmpty(value))
            return value;

        if (value.Length <= maxLength)
            return value;

        return value.Substring(0, maxLength - ellipsis.Length) + ellipsis;
    }

    /// <summary>
    /// Converts a string to title case
    /// </summary>
    /// <param name="value">The string to convert</param>
    /// <returns>String in title case</returns>
    public static string ToTitleCase(this string value)
    {
        if (string.IsNullOrEmpty(value))
            return value;

        var words = value.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length > 0)
            {
                words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
            }
        }
        return string.Join(" ", words);
    }

    /// <summary>
    /// Checks if a string is a valid email address
    /// </summary>
    /// <param name="email">The email string to validate</param>
    /// <returns>True if valid email format, false otherwise</returns>
    public static bool IsValidEmail(this string email)
    {
        if (string.IsNullOrWhiteSpace(email))
            return false;

        try
        {
            var addr = new System.Net.Mail.MailAddress(email);
            return addr.Address == email;
        }
        catch
        {
            return false;
        }
    }

    /// <summary>
    /// Removes all whitespace from a string
    /// </summary>
    /// <param name="value">The string to process</param>
    /// <returns>String without any whitespace</returns>
    public static string RemoveWhitespace(this string value)
    {
        if (string.IsNullOrEmpty(value))
            return value;

        return new string(value.Where(c => !char.IsWhiteSpace(c)).ToArray());
    }
}