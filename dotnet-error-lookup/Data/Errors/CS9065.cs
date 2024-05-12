namespace dotnet_error_lookup.Data.Errors;

public class CS9065 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9065";
    string IErrorOrWarning.Message => @"Do not use 'System.Runtime.CompilerServices.ScopedRefAttribute'. Use the 'scoped' keyword instead.";
    string IErrorOrWarning.Explanation => @"[original] Do not use 'System.Runtime.CompilerServices.ScopedRefAttribute'. Use the 'scoped' keyword instead.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
