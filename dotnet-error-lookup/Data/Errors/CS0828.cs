namespace dotnet_error_lookup.Data.Errors;

public class CS0828 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0828";
    string IErrorOrWarning.Message => @"Cannot assign '{0}' to anonymous type property";
    string IErrorOrWarning.Explanation => @"[original] Cannot assign '{0}' to anonymous type property";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0828";
}
