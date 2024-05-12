namespace dotnet_error_lookup.Data.Errors;

public class CS1651 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1651";
    string IErrorOrWarning.Message => @"Fields of static readonly field '{0}' cannot be used as a ref or out value (except in a static constructor)";
    string IErrorOrWarning.Explanation => @"[original] Fields of static readonly field '{0}' cannot be used as a ref or out value (except in a static constructor)";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1651";
}
