namespace dotnet_error_lookup.Data.Errors;

public class CS1022 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1022";
    string IErrorOrWarning.Message => @"Type or namespace definition, or end-of-file expected";
    string IErrorOrWarning.Explanation => @"[original] Type or namespace definition, or end-of-file expected";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1022";
}
