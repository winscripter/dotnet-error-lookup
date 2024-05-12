namespace dotnet_error_lookup.Data.Errors;

public class CS8830 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8830";
    string IErrorOrWarning.Message => @"'{0}': Target runtime doesn't support covariant return types in overrides. Return type must be '{2}' to match overridden member '{1}'";
    string IErrorOrWarning.Explanation => @"[original] '{0}': Target runtime doesn't support covariant return types in overrides. Return type must be '{2}' to match overridden member '{1}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
