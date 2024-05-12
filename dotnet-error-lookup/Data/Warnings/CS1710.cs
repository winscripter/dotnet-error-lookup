namespace dotnet_error_lookup.Data.Errors;

public class CS1710 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS1710";
    string IErrorOrWarning.Message => @"XML comment has a duplicate typeparam tag for '{0}'";
    string IErrorOrWarning.Explanation => @"[original] XML comment has a duplicate typeparam tag for '{0}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1710";
}
