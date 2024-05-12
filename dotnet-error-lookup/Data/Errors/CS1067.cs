namespace dotnet_error_lookup.Data.Errors;

public class CS1067 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1067";
    string IErrorOrWarning.Message => @"Partial declarations of '{0}' must have the same type parameter names and variance modifiers in the same order";
    string IErrorOrWarning.Explanation => @"[original] Partial declarations of '{0}' must have the same type parameter names and variance modifiers in the same order";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
