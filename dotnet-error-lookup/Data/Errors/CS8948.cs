namespace dotnet_error_lookup.Data.Errors;

public class CS8948 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8948";
    string IErrorOrWarning.Message => @"InterpolatedStringHandlerArgumentAttribute arguments cannot refer to the parameter the attribute is used on.";
    string IErrorOrWarning.Explanation => @"[original] InterpolatedStringHandlerArgumentAttribute arguments cannot refer to the parameter the attribute is used on.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
