namespace dotnet_error_lookup.Data.Errors;

public class CS7019 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS7019";
    string IErrorOrWarning.Message => @"Type of '{0}' cannot be inferred since its initializer directly or indirectly refers to the definition.";
    string IErrorOrWarning.Explanation => @"[original] Type of '{0}' cannot be inferred since its initializer directly or indirectly refers to the definition.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
