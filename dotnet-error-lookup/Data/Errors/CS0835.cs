namespace dotnet_error_lookup.Data.Errors;

public class CS0835 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0835";
    string IErrorOrWarning.Message => @"Cannot convert lambda to an expression tree whose type argument '{0}' is not a delegate type";
    string IErrorOrWarning.Explanation => @"[original] Cannot convert lambda to an expression tree whose type argument '{0}' is not a delegate type";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0835";
}
