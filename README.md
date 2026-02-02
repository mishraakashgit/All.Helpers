# MishraAllHelpers

A simple and useful .NET utility library providing common helper functions for string manipulation, date handling, and validation.

## Installation

```bash
dotnet add package MishraAllHelpers
```

Or via NuGet Package Manager:

```
Install-Package MishraAllHelpers
```

## Features

### String Extensions

- **Truncate**: Truncate strings with ellipsis
- **ToTitleCase**: Convert strings to title case
- **IsValidEmail**: Validate email addresses
- **RemoveWhitespace**: Remove all whitespace from strings

### DateTime Extensions

- **StartOfDay/EndOfDay**: Get the start or end of a day
- **IsWeekend**: Check if a date falls on a weekend
- **GetAge**: Calculate age from a birth date
- **ToRelativeTime**: Get friendly relative time strings (e.g., "2 hours ago")

### Validation Utilities

- **RequireNonEmpty**: Validate non-empty strings
- **RequireInRange**: Validate values within a range
- **RequireNotNull**: Validate non-null objects
- **RequireNonEmpty**: Validate non-empty collections

## Usage Examples

### String Extensions

```csharp
using AllHelpers.Extensions;

string text = "This is a very long string that needs truncating";
string truncated = text.Truncate(20); // "This is a very lo..."

string email = "test@example.com";
bool isValid = email.IsValidEmail(); // true

string name = "john doe";
string titleCase = name.ToTitleCase(); // "John Doe"
```

### DateTime Extensions

```csharp
using AllHelpers.Extensions;

DateTime date = DateTime.Now;
bool weekend = date.IsWeekend();

DateTime birthDate = new DateTime(1990, 5, 15);
int age = birthDate.GetAge();

DateTime past = DateTime.Now.AddHours(-3);
string relative = past.ToRelativeTime(); // "3 hours ago"
```

### Validation Utilities

```csharp
using AllHelpers.Utilities;

void ProcessName(string name)
{
    Validator.RequireNonEmpty(name, nameof(name));
    // Process the name...
}

void SetAge(int age)
{
    Validator.RequireInRange(age, 0, 150, nameof(age));
    // Set the age...
}
```

## License

MIT License - feel free to use this in your projects!

## Contributing

Contributions are welcome! Please feel free to submit a Pull Request.