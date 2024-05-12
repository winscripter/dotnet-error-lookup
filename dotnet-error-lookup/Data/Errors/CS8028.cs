namespace dotnet_error_lookup.Data.Errors;

public class CS8028 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8028";
    string IErrorOrWarning.Message => @"'{0}': a class with the ComImport attribute cannot specify field initializers.";
    string IErrorOrWarning.Explanation => @"[original] '{0}': a class with the ComImport attribute cannot specify field initializers.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
