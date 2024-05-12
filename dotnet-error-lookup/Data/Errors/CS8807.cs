namespace dotnet_error_lookup.Data.Errors;

public class CS8807 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8807";
    string IErrorOrWarning.Message => @"'{0}' is not a valid calling convention specifier for a function pointer.";
    string IErrorOrWarning.Explanation => @"[original] '{0}' is not a valid calling convention specifier for a function pointer.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
