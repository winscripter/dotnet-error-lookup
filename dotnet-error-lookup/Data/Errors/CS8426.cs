namespace dotnet_error_lookup.Data.Errors;

public class CS8426 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8426";
    string IErrorOrWarning.Message => @"The attribute [EnumeratorCancellation] cannot be used on multiple parameters";
    string IErrorOrWarning.Explanation => @"[original] The attribute [EnumeratorCancellation] cannot be used on multiple parameters";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
