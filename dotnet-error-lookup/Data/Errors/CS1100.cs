namespace dotnet_error_lookup.Data.Errors;

public class CS1100 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1100";
    string IErrorOrWarning.Message => @"Method '{0}' has a parameter modifier 'this' which is not on the first parameter";
    string IErrorOrWarning.Explanation => @"[original] Method '{0}' has a parameter modifier 'this' which is not on the first parameter";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1100";
}
