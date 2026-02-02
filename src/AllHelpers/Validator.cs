namespace AllHelpers.Utilities;

/// <summary>
/// Common validation utilities
/// </summary>
public static class Validator
{
    /// <summary>
    /// Validates if a string is not null or empty
    /// </summary>
    /// <param name="value">The value to check</param>
    /// <param name="paramName">Parameter name for exception</param>
    /// <exception cref="ArgumentException">Thrown when value is null or empty</exception>
    public static void RequireNonEmpty(string value, string paramName)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentException($"{paramName} cannot be null or empty.", paramName);
    }

    /// <summary>
    /// Validates if a value is within a specified range
    /// </summary>
    /// <typeparam name="T">Type of value (must be comparable)</typeparam>
    /// <param name="value">The value to check</param>
    /// <param name="min">Minimum value (inclusive)</param>
    /// <param name="max">Maximum value (inclusive)</param>
    /// <param name="paramName">Parameter name for exception</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when value is outside range</exception>
    public static void RequireInRange<T>(T value, T min, T max, string paramName) where T : IComparable<T>
    {
        if (value.CompareTo(min) < 0 || value.CompareTo(max) > 0)
            throw new ArgumentOutOfRangeException(paramName, $"{paramName} must be between {min} and {max}.");
    }

    /// <summary>
    /// Validates if an object is not null
    /// </summary>
    /// <typeparam name="T">Type of object</typeparam>
    /// <param name="value">The value to check</param>
    /// <param name="paramName">Parameter name for exception</param>
    /// <exception cref="ArgumentNullException">Thrown when value is null</exception>
    public static void RequireNotNull<T>(T value, string paramName) where T : class
    {
        if (value == null)
            throw new ArgumentNullException(paramName);
    }

    /// <summary>
    /// Validates if a collection is not null or empty
    /// </summary>
    /// <typeparam name="T">Type of collection items</typeparam>
    /// <param name="collection">The collection to check</param>
    /// <param name="paramName">Parameter name for exception</param>
    /// <exception cref="ArgumentException">Thrown when collection is null or empty</exception>
    public static void RequireNonEmpty<T>(IEnumerable<T> collection, string paramName)
    {
        if (collection == null || !collection.Any())
            throw new ArgumentException($"{paramName} cannot be null or empty.", paramName);
    }
}