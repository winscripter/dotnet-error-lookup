namespace dotnet_error_lookup.Data.Errors;

public class CS0316 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0316";
    string IErrorOrWarning.Message => @"The parameter name '{0}' conflicts with an automatically-generated parameter name";
    string IErrorOrWarning.Explanation => @"[original] The parameter name '{0}' conflicts with an automatically-generated parameter name";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0316";
}
