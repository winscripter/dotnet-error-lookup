namespace dotnet_error_lookup.Data.Errors;

public class CS0133 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0133";
    string IErrorOrWarning.Message => @"The expression being assigned to '{0}' must be constant";
    string IErrorOrWarning.Explanation => @"[original] The expression being assigned to '{0}' must be constant";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0133";
}
