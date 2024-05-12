namespace dotnet_error_lookup.Data.Errors;

public class CS0718 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0718";
    string IErrorOrWarning.Message => @"'{0}': static types cannot be used as type arguments";
    string IErrorOrWarning.Explanation => @"[original] '{0}': static types cannot be used as type arguments";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0718";
}
