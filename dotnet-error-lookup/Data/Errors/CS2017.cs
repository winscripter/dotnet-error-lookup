namespace dotnet_error_lookup.Data.Errors;

public class CS2017 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS2017";
    string IErrorOrWarning.Message => @"Cannot specify /main if building a module or library";
    string IErrorOrWarning.Explanation => @"[original] Cannot specify /main if building a module or library";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs2017";
}
