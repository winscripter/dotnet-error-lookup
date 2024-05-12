namespace dotnet_error_lookup.Data.Errors;

public class CS8917 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8917";
    string IErrorOrWarning.Message => @"The delegate type could not be inferred.";
    string IErrorOrWarning.Explanation => @"[original] The delegate type could not be inferred.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
