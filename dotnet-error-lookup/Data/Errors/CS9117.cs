namespace dotnet_error_lookup.Data.Errors;

public class CS9117 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9117";
    string IErrorOrWarning.Message => @"Members of primary constructor parameter '{0}' of a readonly type cannot be modified (except in init-only setter of the type or a variable initializer)";
    string IErrorOrWarning.Explanation => @"[original] Members of primary constructor parameter '{0}' of a readonly type cannot be modified (except in init-only setter of the type or a variable initializer)";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
