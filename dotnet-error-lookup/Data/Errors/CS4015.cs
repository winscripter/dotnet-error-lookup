namespace dotnet_error_lookup.Data.Errors;

public class CS4015 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS4015";
    string IErrorOrWarning.Message => @"'MethodImplOptions.Synchronized' cannot be applied to an async method";
    string IErrorOrWarning.Explanation => @"[original] 'MethodImplOptions.Synchronized' cannot be applied to an async method";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
