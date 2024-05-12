namespace dotnet_error_lookup.Data.Errors;

public class CS8632 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8632";
    string IErrorOrWarning.Message => @"The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.";
    string IErrorOrWarning.Explanation => @"[original] The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
