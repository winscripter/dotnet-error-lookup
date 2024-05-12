namespace dotnet_error_lookup.Data.Errors;

public class CS1677 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1677";
    string IErrorOrWarning.Message => @"Parameter {0} should not be declared with the '{1}' keyword";
    string IErrorOrWarning.Explanation => @"[original] Parameter {0} should not be declared with the '{1}' keyword";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1677";
}
