namespace dotnet_error_lookup.Data.Errors;

public class CS8831 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8831";
    string IErrorOrWarning.Message => @"'{0}': Target runtime doesn't support covariant types in overrides. Type must be '{2}' to match overridden member '{1}'";
    string IErrorOrWarning.Explanation => @"[original] '{0}': Target runtime doesn't support covariant types in overrides. Type must be '{2}' to match overridden member '{1}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
