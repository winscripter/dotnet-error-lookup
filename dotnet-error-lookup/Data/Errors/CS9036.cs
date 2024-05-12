namespace dotnet_error_lookup.Data.Errors;

public class CS9036 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9036";
    string IErrorOrWarning.Message => @"Required member '{0}' must be assigned a value, it cannot use a nested member or collection initializer.";
    string IErrorOrWarning.Explanation => @"[original] Required member '{0}' must be assigned a value, it cannot use a nested member or collection initializer.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
