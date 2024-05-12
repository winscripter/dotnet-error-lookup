namespace dotnet_error_lookup.Data.Errors;

public class CS0746 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0746";
    string IErrorOrWarning.Message => @"Invalid anonymous type member declarator. Anonymous type members must be declared with a member assignment, simple name or member access.";
    string IErrorOrWarning.Explanation => @"[original] Invalid anonymous type member declarator. Anonymous type members must be declared with a member assignment, simple name or member access.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0746";
}
