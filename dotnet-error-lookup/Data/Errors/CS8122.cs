namespace dotnet_error_lookup.Data.Errors;

public class CS8122 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8122";
    string IErrorOrWarning.Message => @"An expression tree may not contain an 'is' pattern-matching operator.";
    string IErrorOrWarning.Explanation => @"[original] An expression tree may not contain an 'is' pattern-matching operator.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
