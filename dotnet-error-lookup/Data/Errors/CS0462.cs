namespace dotnet_error_lookup.Data.Errors;

public class CS0462 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0462";
    string IErrorOrWarning.Message => @"The inherited members '{0}' and '{1}' have the same signature in type '{2}', so they cannot be overridden";
    string IErrorOrWarning.Explanation => @"[original] The inherited members '{0}' and '{1}' have the same signature in type '{2}', so they cannot be overridden";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0462";
}
