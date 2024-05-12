namespace dotnet_error_lookup.Data.Errors;

public class CS9119 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9119";
    string IErrorOrWarning.Message => @"Members of primary constructor parameter '{0}' of a readonly type cannot be used as a ref or out value (except in init-only setter of the type or a variable initializer)";
    string IErrorOrWarning.Explanation => @"[original] Members of primary constructor parameter '{0}' of a readonly type cannot be used as a ref or out value (except in init-only setter of the type or a variable initializer)";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
