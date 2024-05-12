namespace dotnet_error_lookup.Data.Errors;

public class CS0633 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0633";
    string IErrorOrWarning.Message => @"The argument to the '{0}' attribute must be a valid identifier";
    string IErrorOrWarning.Explanation => @"[original] The argument to the '{0}' attribute must be a valid identifier";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0633";
}
