namespace dotnet_error_lookup.Data.Errors;

public class CS8326 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8326";
    string IErrorOrWarning.Message => @"Both conditional operator values must be ref values or neither may be a ref value";
    string IErrorOrWarning.Explanation => @"[original] Both conditional operator values must be ref values or neither may be a ref value";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
