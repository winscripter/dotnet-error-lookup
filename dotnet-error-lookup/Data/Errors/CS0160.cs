namespace dotnet_error_lookup.Data.Errors;

public class CS0160 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0160";
    string IErrorOrWarning.Message => @"A previous catch clause already catches all exceptions of this or of a super type ('{0}')";
    string IErrorOrWarning.Explanation => @"[original] A previous catch clause already catches all exceptions of this or of a super type ('{0}')";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0160";
}
