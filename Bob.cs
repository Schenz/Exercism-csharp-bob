using System;

public static class Bob
{
    public static string Response(string statement)
    {
        if (String.IsNullOrWhiteSpace(statement.Trim())) {
            return "Fine. Be that way!";
        } else if (IsAllUpper(statement.Trim()) && IsQuestion(statement.Trim())){
            return "Calm down, I know what I'm doing!";
        } else if (IsAllUpper(statement.Trim())) {
            return "Whoa, chill out!";
        } else if (IsQuestion(statement.Trim())) {
            return "Sure.";
        } else {
            return "Whatever.";
        }
    }

    private static bool IsAllUpper(string input)
    {
        var noAlpha = true;

        for (int i = 0; i < input.Length; i++)
        {
            if (Char.IsLetter(input[i]) && !Char.IsUpper(input[i])) {
                return false;
            }

            if (Char.IsLetter(input[i])) {
                noAlpha = false;
            }
        }

        return !noAlpha;
    }

    private static bool IsQuestion (string input) {
        if (!String.IsNullOrWhiteSpace(input) && input.Substring(input.Length - 1) == "?") {
            return true;
        } else {
            return false;
        }
    }
}