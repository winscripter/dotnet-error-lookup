namespace dotnet_error_lookup.Data.Errors;

public class CS9091 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS9091";
    string IErrorOrWarning.Message => @"This returns local '{0}' by reference but it is not a ref local";
    string IErrorOrWarning.Explanation => @"[original] This returns local '{0}' by reference but it is not a ref local";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
