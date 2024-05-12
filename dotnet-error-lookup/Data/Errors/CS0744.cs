namespace dotnet_error_lookup.Data.Errors;

public class CS0744 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0744";
    string IErrorOrWarning.Message => @"Expected contextual keyword 'equals'";
    string IErrorOrWarning.Explanation => @"[original] Expected contextual keyword 'equals'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0744";
}
