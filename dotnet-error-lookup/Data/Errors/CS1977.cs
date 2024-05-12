namespace dotnet_error_lookup.Data.Errors;

public class CS1977 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1977";
    string IErrorOrWarning.Message => @"Cannot use a lambda expression as an argument to a dynamically dispatched operation without first casting it to a delegate or expression tree type.";
    string IErrorOrWarning.Explanation => @"[original] Cannot use a lambda expression as an argument to a dynamically dispatched operation without first casting it to a delegate or expression tree type.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
