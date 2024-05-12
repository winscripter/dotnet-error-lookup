namespace dotnet_error_lookup.Data.Errors;

public class CS1681 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1681";
    string IErrorOrWarning.Message => @"You cannot redefine the global extern alias";
    string IErrorOrWarning.Explanation => @"[original] You cannot redefine the global extern alias";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1681";
}
