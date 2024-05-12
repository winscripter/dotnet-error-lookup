namespace dotnet_error_lookup.Data.Errors;

public class CS7015 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS7015";
    string IErrorOrWarning.Message => @"'extern alias' is not valid in this context";
    string IErrorOrWarning.Explanation => @"[original] 'extern alias' is not valid in this context";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
