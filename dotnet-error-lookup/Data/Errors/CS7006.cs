namespace dotnet_error_lookup.Data.Errors;

public class CS7006 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS7006";
    string IErrorOrWarning.Message => @"Expressions and statements can only occur in a method body";
    string IErrorOrWarning.Explanation => @"[original] Expressions and statements can only occur in a method body";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
