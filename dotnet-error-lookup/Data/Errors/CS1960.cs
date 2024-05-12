namespace dotnet_error_lookup.Data.Errors;

public class CS1960 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1960";
    string IErrorOrWarning.Message => @"Invalid variance modifier. Only interface and delegate type parameters can be specified as variant.";
    string IErrorOrWarning.Explanation => @"[original] Invalid variance modifier. Only interface and delegate type parameters can be specified as variant.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
