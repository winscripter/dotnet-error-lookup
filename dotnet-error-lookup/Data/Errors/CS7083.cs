namespace dotnet_error_lookup.Data.Errors;

public class CS7083 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS7083";
    string IErrorOrWarning.Message => @"Expression must be implicitly convertible to Boolean or its type '{0}' must define operator '{1}'.";
    string IErrorOrWarning.Explanation => @"[original] Expression must be implicitly convertible to Boolean or its type '{0}' must define operator '{1}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
