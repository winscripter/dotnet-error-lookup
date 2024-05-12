namespace dotnet_error_lookup.Data.Errors;

public class CS9032 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9032";
    string IErrorOrWarning.Message => @"Required member '{0}' cannot be less visible or have a setter less visible than the containing type '{1}'.";
    string IErrorOrWarning.Explanation => @"[original] Required member '{0}' cannot be less visible or have a setter less visible than the containing type '{1}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
