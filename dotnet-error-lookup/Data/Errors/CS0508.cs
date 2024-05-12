namespace dotnet_error_lookup.Data.Errors;

public class CS0508 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0508";
    string IErrorOrWarning.Message => @"'{0}': return type must be '{2}' to match overridden member '{1}'";
    string IErrorOrWarning.Explanation => @"[original] '{0}': return type must be '{2}' to match overridden member '{1}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0508";
}
