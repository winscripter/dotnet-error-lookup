namespace dotnet_error_lookup.Data.Errors;

public class CS1967 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1967";
    string IErrorOrWarning.Message => @"Constraint cannot be the dynamic type";
    string IErrorOrWarning.Explanation => @"[original] Constraint cannot be the dynamic type";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
