namespace dotnet_error_lookup.Data.Errors;

public class CS1962 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1962";
    string IErrorOrWarning.Message => @"The typeof operator cannot be used on the dynamic type";
    string IErrorOrWarning.Explanation => @"[original] The typeof operator cannot be used on the dynamic type";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
