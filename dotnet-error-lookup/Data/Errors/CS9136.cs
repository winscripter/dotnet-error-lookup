namespace dotnet_error_lookup.Data.Errors;

public class CS9136 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9136";
    string IErrorOrWarning.Message => @"Cannot use primary constructor parameter of type '{0}' inside an instance member";
    string IErrorOrWarning.Explanation => @"[original] Cannot use primary constructor parameter of type '{0}' inside an instance member";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
