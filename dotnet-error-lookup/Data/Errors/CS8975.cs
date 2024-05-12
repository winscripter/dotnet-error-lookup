namespace dotnet_error_lookup.Data.Errors;

public class CS8975 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8975";
    string IErrorOrWarning.Message => @"The contextual keyword 'var' cannot be used as an explicit lambda return type";
    string IErrorOrWarning.Explanation => @"[original] The contextual keyword 'var' cannot be used as an explicit lambda return type";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
