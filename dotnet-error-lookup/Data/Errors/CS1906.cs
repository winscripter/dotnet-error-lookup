namespace dotnet_error_lookup.Data.Errors;

public class CS1906 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1906";
    string IErrorOrWarning.Message => @"Invalid option '{0}'; Resource visibility must be either 'public' or 'private'";
    string IErrorOrWarning.Explanation => @"[original] Invalid option '{0}'; Resource visibility must be either 'public' or 'private'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1906";
}
