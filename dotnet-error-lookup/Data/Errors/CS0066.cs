namespace dotnet_error_lookup.Data.Errors;

public class CS0066 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0066";
    string IErrorOrWarning.Message => @"'{0}': event must be of a delegate type";
    string IErrorOrWarning.Explanation => @"[original] '{0}': event must be of a delegate type";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0066";
}
