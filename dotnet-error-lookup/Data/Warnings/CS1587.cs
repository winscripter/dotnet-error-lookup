namespace dotnet_error_lookup.Data.Errors;

public class CS1587 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS1587";
    string IErrorOrWarning.Message => @"XML comment is not placed on a valid language element";
    string IErrorOrWarning.Explanation => @"[original] XML comment is not placed on a valid language element";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1587";
}
