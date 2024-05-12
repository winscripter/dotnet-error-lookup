namespace dotnet_error_lookup.Data.Errors;

public class CS1689 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1689";
    string IErrorOrWarning.Message => @"Attribute '{0}' is only valid on methods or attribute classes";
    string IErrorOrWarning.Explanation => @"[original] Attribute '{0}' is only valid on methods or attribute classes";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1689";
}
