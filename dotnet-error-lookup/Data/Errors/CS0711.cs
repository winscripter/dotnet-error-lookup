namespace dotnet_error_lookup.Data.Errors;

public class CS0711 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0711";
    string IErrorOrWarning.Message => @"Static classes cannot contain destructors";
    string IErrorOrWarning.Explanation => @"[original] Static classes cannot contain destructors";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0711";
}
