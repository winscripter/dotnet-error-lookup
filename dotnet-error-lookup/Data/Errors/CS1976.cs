namespace dotnet_error_lookup.Data.Errors;

public class CS1976 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1976";
    string IErrorOrWarning.Message => @"Cannot use a method group as an argument to a dynamically dispatched operation. Did you intend to invoke the method?";
    string IErrorOrWarning.Explanation => @"[original] Cannot use a method group as an argument to a dynamically dispatched operation. Did you intend to invoke the method?";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
