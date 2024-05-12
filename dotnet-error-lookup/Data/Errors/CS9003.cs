namespace dotnet_error_lookup.Data.Errors;

public class CS9003 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9003";
    string IErrorOrWarning.Message => @"Line contains different whitespace than the closing line of the raw string literal: '{0}' versus '{1}'";
    string IErrorOrWarning.Explanation => @"[original] Line contains different whitespace than the closing line of the raw string literal: '{0}' versus '{1}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
