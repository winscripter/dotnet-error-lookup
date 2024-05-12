namespace dotnet_error_lookup.Data.Errors;

public class CS0416 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0416";
    string IErrorOrWarning.Message => @"'{0}': an attribute argument cannot use type parameters";
    string IErrorOrWarning.Explanation => @"[original] '{0}': an attribute argument cannot use type parameters";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0416";
}
