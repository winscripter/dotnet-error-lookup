namespace dotnet_error_lookup.Data.Errors;

public class CS1643 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1643";
    string IErrorOrWarning.Message => @"Not all code paths return a value in {0} of type '{1}'";
    string IErrorOrWarning.Explanation => @"[original] Not all code paths return a value in {0} of type '{1}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1643";
}
