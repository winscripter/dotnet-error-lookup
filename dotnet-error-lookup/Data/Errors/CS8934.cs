namespace dotnet_error_lookup.Data.Errors;

public class CS8934 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8934";
    string IErrorOrWarning.Message => @"Cannot convert {0} to type '{1}' because the return type does not match the delegate return type";
    string IErrorOrWarning.Explanation => @"[original] Cannot convert {0} to type '{1}' because the return type does not match the delegate return type";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
