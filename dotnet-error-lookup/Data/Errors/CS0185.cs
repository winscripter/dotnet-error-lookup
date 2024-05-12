namespace dotnet_error_lookup.Data.Errors;

public class CS0185 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0185";
    string IErrorOrWarning.Message => @"'{0}' is not a reference type as required by the lock statement";
    string IErrorOrWarning.Explanation => @"[original] '{0}' is not a reference type as required by the lock statement";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0185";
}
