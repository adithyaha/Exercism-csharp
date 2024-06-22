using System;
using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        if (identifier.Length == 1)
        {
            return identifier.ToUpper();
        }

        StringBuilder sb = new StringBuilder();

        bool capitalizeNext = false;
        foreach (char c in identifier)
        {
            // Replace whitespaces with underscores
            if (char.IsWhiteSpace(c))
            {
                sb.Append('_');
                continue;
            }

            // Replace control characters with "CTRL"
            if (char.IsControl(c))
            {
                sb.Append("CTRL");
                continue;
            }

            // Remove Greek lowercase letters
            if (c >= 945 && c <= 969)
            {
                continue;
            }

            // Handle kebab-case to camelCase
            if (c == '-')
            {
                capitalizeNext = true;
                continue;
            }

            // Omit non-letter characters
            if (!char.IsLetter(c))
            {
                continue;
            }

            // Handle capitalization for camelCase
            if (capitalizeNext)
            {
                sb.Append(char.ToUpper(c));
                capitalizeNext = false;
            }
            else
            {
                sb.Append(c);
            }
        }

        // Ensure the first character is uppercase if the identifier was one character long
        if (sb.Length == 1)
        {
            sb[0] = char.ToUpper(sb[0]);
        }

        return sb.ToString();
    }
}
