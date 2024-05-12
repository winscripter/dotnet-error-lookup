namespace dotnet_error_lookup.Data.Errors;

public class CS8801 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8801";
    string IErrorOrWarning.Message => @"Cannot use local variable or local function '{0}' declared in a top-level statement in this context.";
    string IErrorOrWarning.Explanation => @"[original] Cannot use local variable or local function '{0}' declared in a top-level statement in this context.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
