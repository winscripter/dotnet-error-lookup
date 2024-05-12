namespace dotnet_error_lookup.Data.Errors;

public class CS8648 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8648";
    string IErrorOrWarning.Message => @"A goto cannot jump to a location after a using declaration.";
    string IErrorOrWarning.Explanation => @"[original] A goto cannot jump to a location after a using declaration.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
