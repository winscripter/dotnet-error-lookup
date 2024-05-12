namespace dotnet_error_lookup.Data.Errors;

public class CS0100 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0100";
    string IErrorOrWarning.Message => @"The parameter name '{0}' is a duplicate";
    string IErrorOrWarning.Explanation => @"[original] The parameter name '{0}' is a duplicate";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0100";
}
