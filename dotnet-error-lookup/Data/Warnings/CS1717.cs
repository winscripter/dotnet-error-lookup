namespace dotnet_error_lookup.Data.Errors;

public class CS1717 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS1717";
    string IErrorOrWarning.Message => @"Assignment made to same variable; did you mean to assign something else?";
    string IErrorOrWarning.Explanation => @"[original] Assignment made to same variable; did you mean to assign something else?";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1717";
}
