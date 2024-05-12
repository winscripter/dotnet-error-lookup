namespace dotnet_error_lookup.Data.Errors;

public class CS0157 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0157";
    string IErrorOrWarning.Message => @"Control cannot leave the body of a finally clause";
    string IErrorOrWarning.Explanation => @"[original] Control cannot leave the body of a finally clause";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0157";
}
