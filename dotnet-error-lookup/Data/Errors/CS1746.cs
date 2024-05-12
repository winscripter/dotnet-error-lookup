namespace dotnet_error_lookup.Data.Errors;

public class CS1746 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1746";
    string IErrorOrWarning.Message => @"The delegate '{0}' does not have a parameter named '{1}'";
    string IErrorOrWarning.Explanation => @"[original] The delegate '{0}' does not have a parameter named '{1}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
