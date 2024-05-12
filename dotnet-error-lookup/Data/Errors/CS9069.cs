namespace dotnet_error_lookup.Data.Errors;

public class CS9069 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9069";
    string IErrorOrWarning.Message => @"File-local type '{0}' cannot be used because the containing file path cannot be converted into the equivalent UTF-8 byte representation. {1}";
    string IErrorOrWarning.Explanation => @"[original] File-local type '{0}' cannot be used because the containing file path cannot be converted into the equivalent UTF-8 byte representation. {1}";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
