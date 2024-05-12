namespace dotnet_error_lookup.Data.Errors;

public class CS9114 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9114";
    string IErrorOrWarning.Message => @"A primary constructor parameter of a readonly type cannot be assigned to (except in init-only setter of the type or a variable initializer)";
    string IErrorOrWarning.Explanation => @"[original] A primary constructor parameter of a readonly type cannot be assigned to (except in init-only setter of the type or a variable initializer)";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
