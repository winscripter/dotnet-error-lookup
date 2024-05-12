namespace dotnet_error_lookup.Data.Errors;

public class CS7008 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS7008";
    string IErrorOrWarning.Message => @"The assembly name '{0}' is reserved and cannot be used as a reference in an interactive session";
    string IErrorOrWarning.Explanation => @"[original] The assembly name '{0}' is reserved and cannot be used as a reference in an interactive session";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
