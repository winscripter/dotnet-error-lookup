namespace dotnet_error_lookup.Data.Errors;

public class CS0182 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0182";
    string IErrorOrWarning.Message => @"An attribute argument must be a constant expression, typeof expression or array creation expression of an attribute parameter type";
    string IErrorOrWarning.Explanation => @"[original] An attribute argument must be a constant expression, typeof expression or array creation expression of an attribute parameter type";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0182";
}
