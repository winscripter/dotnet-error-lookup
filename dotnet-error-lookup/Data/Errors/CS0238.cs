namespace dotnet_error_lookup.Data.Errors;

public class CS0238 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0238";
    string IErrorOrWarning.Message => @"'{0}' cannot be sealed because it is not an override";
    string IErrorOrWarning.Explanation => @"[original] '{0}' cannot be sealed because it is not an override";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0238";
}
