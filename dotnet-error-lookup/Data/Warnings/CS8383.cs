namespace dotnet_error_lookup.Data.Errors;

public class CS8383 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8383";
    string IErrorOrWarning.Message => @"The tuple element name '{0}' is ignored because a different name or no name is specified on the other side of the tuple == or != operator.";
    string IErrorOrWarning.Explanation => @"[original] The tuple element name '{0}' is ignored because a different name or no name is specified on the other side of the tuple == or != operator.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
