namespace dotnet_error_lookup.Data.Errors;

public class CS1964 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1964";
    string IErrorOrWarning.Message => @"'{0}': user-defined conversions to or from the dynamic type are not allowed";
    string IErrorOrWarning.Explanation => @"[original] '{0}': user-defined conversions to or from the dynamic type are not allowed";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
