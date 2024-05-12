namespace dotnet_error_lookup.Data.Errors;

public class CS8618 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8618";
    string IErrorOrWarning.Message => @"Non-nullable {0} '{1}' must contain a non-null value when exiting constructor. Consider declaring the {0} as nullable.";
    string IErrorOrWarning.Explanation => @"[original] Non-nullable {0} '{1}' must contain a non-null value when exiting constructor. Consider declaring the {0} as nullable.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings";
}
