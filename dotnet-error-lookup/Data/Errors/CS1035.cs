namespace dotnet_error_lookup.Data.Errors;

public class CS1035 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1035";
    string IErrorOrWarning.Message => @"End-of-file found, '*/' expected";
    string IErrorOrWarning.Explanation => @"[original] End-of-file found, '\*/' expected";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1035";
}
