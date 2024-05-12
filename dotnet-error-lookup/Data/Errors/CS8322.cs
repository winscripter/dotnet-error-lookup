namespace dotnet_error_lookup.Data.Errors;

public class CS8322 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8322";
    string IErrorOrWarning.Message => @"Cannot pass argument with dynamic type to generic local function '{0}' with inferred type arguments.";
    string IErrorOrWarning.Explanation => @"[original] Cannot pass argument with dynamic type to generic local function '{0}' with inferred type arguments.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
