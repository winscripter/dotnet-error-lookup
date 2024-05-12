namespace dotnet_error_lookup.Data.Errors;

public class CS1711 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS1711";
    string IErrorOrWarning.Message => @"XML comment has a typeparam tag for '{0}', but there is no type parameter by that name";
    string IErrorOrWarning.Explanation => @"[original] XML comment has a typeparam tag for '{0}', but there is no type parameter by that name";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1711";
}
