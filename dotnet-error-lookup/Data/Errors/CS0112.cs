namespace dotnet_error_lookup.Data.Errors;

public class CS0112 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0112";
    string IErrorOrWarning.Message => @"A static member cannot be marked as '{0}'";
    string IErrorOrWarning.Explanation => @"[original] A static member cannot be marked as '{0}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0112";
}
