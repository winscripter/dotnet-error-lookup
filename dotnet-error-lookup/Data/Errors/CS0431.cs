namespace dotnet_error_lookup.Data.Errors;

public class CS0431 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0431";
    string IErrorOrWarning.Message => @"Cannot use alias '{0}' with '::' since the alias references a type. Use '.' instead.";
    string IErrorOrWarning.Explanation => @"[original] Cannot use alias '{0}' with '::' since the alias references a type. Use '.' instead.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0431";
}
