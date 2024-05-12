namespace dotnet_error_lookup.Data.Errors;

public class CS9059 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9059";
    string IErrorOrWarning.Message => @"A ref field can only be declared in a ref struct.";
    string IErrorOrWarning.Explanation => @"[original] A ref field can only be declared in a ref struct.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
