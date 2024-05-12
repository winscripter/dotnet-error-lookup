namespace dotnet_error_lookup.Data.Errors;

public class CS0464 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS0464";
    string IErrorOrWarning.Message => @"Comparing with null of type '{0}' always produces 'false'";
    string IErrorOrWarning.Explanation => @"[original] Comparing with null of type '{0}' always produces 'false'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0464";
}
