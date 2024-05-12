namespace dotnet_error_lookup.Data.Errors;

public class CS0123 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0123";
    string IErrorOrWarning.Message => @"No overload for '{0}' matches delegate '{1}'";
    string IErrorOrWarning.Explanation => @"[original] No overload for '{0}' matches delegate '{1}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0123";
}
