namespace dotnet_error_lookup.Data.Errors;

public class CS9026 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9026";
    string IErrorOrWarning.Message => @"The input string cannot be converted into the equivalent UTF-8 byte representation. {0}";
    string IErrorOrWarning.Explanation => @"[original] The input string cannot be converted into the equivalent UTF-8 byte representation. {0}";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
