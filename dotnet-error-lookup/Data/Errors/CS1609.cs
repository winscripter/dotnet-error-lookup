namespace dotnet_error_lookup.Data.Errors;

public class CS1609 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1609";
    string IErrorOrWarning.Message => @"Modifiers cannot be placed on event accessor declarations";
    string IErrorOrWarning.Explanation => @"[original] Modifiers cannot be placed on event accessor declarations";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1609";
}
