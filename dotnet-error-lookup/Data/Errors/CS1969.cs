namespace dotnet_error_lookup.Data.Errors;

public class CS1969 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1969";
    string IErrorOrWarning.Message => @"One or more types required to compile a dynamic expression cannot be found. Are you missing a reference?";
    string IErrorOrWarning.Explanation => @"[original] One or more types required to compile a dynamic expression cannot be found. Are you missing a reference?";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
