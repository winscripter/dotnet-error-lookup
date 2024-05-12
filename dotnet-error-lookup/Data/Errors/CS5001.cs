namespace dotnet_error_lookup.Data.Errors;

public class CS5001 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS5001";
    string IErrorOrWarning.Message => @"Program does not contain a static 'Main' method suitable for an entry point";
    string IErrorOrWarning.Explanation => @"[original] Program does not contain a static 'Main' method suitable for an entry point";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs5001";
}
