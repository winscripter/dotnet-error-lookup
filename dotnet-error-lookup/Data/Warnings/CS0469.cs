namespace dotnet_error_lookup.Data.Errors;

public class CS0469 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS0469";
    string IErrorOrWarning.Message => @"The 'goto case' value is not implicitly convertible to type '{0}'";
    string IErrorOrWarning.Explanation => @"[original] The 'goto case' value is not implicitly convertible to type '{0}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0469";
}
