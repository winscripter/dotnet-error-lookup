namespace dotnet_error_lookup.Data.Errors;

public class CS8930 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8930";
    string IErrorOrWarning.Message => @"Explicit implementation of a user-defined operator '{0}' must be declared static";
    string IErrorOrWarning.Explanation => @"[original] Explicit implementation of a user-defined operator '{0}' must be declared static";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
