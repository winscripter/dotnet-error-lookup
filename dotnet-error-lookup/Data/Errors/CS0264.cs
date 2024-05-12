namespace dotnet_error_lookup.Data.Errors;

public class CS0264 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0264";
    string IErrorOrWarning.Message => @"Partial declarations of '{0}' must have the same type parameter names in the same order";
    string IErrorOrWarning.Explanation => @"[original] Partial declarations of '{0}' must have the same type parameter names in the same order";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0264";
}
