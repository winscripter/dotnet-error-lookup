namespace dotnet_error_lookup.Data.Errors;

public class CS1769 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1769";
    string IErrorOrWarning.Message => @"Type '{0}' from assembly '{1}' cannot be used across assembly boundaries because it has a generic type argument that is an embedded interop type.";
    string IErrorOrWarning.Explanation => @"[original] Type '{0}' from assembly '{1}' cannot be used across assembly boundaries because it has a generic type argument that is an embedded interop type.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
