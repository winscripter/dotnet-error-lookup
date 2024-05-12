namespace dotnet_error_lookup.Data.Errors;

public class CS0557 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0557";
    string IErrorOrWarning.Message => @"Duplicate user-defined conversion in type '{0}'";
    string IErrorOrWarning.Explanation => @"[original] Duplicate user-defined conversion in type '{0}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0557";
}
