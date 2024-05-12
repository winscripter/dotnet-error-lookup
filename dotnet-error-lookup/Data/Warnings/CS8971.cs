namespace dotnet_error_lookup.Data.Errors;

public class CS8971 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8971";
    string IErrorOrWarning.Message => @"InterpolatedStringHandlerArgument has no effect when applied to lambda parameters and will be ignored at the call site.";
    string IErrorOrWarning.Explanation => @"[original] InterpolatedStringHandlerArgument has no effect when applied to lambda parameters and will be ignored at the call site.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
