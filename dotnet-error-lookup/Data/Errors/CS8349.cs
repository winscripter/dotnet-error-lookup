namespace dotnet_error_lookup.Data.Errors;

public class CS8349 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8349";
    string IErrorOrWarning.Message => @"Expression cannot be used in this context because it may indirectly expose variables outside of their declaration scope";
    string IErrorOrWarning.Explanation => @"[original] Expression cannot be used in this context because it may indirectly expose variables outside of their declaration scope";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
