namespace dotnet_error_lookup.Data.Errors;

public class CS8630 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8630";
    string IErrorOrWarning.Message => @"Invalid '{0}' value: '{1}' for C# {2}. Please use language version '{3}' or greater.";
    string IErrorOrWarning.Explanation => @"[original] Invalid '{0}' value: '{1}' for C# {2}. Please use language version '{3}' or greater.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/feature-version-errors";
}
