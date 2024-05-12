namespace dotnet_error_lookup.Data.Errors;

public class CS8418 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8418";
    string IErrorOrWarning.Message => @"'{0}': type used in a using statement must be implicitly convertible to 'System.IDisposable'. Did you mean 'await using' rather than 'using'?";
    string IErrorOrWarning.Explanation => @"[original] '{0}': type used in a using statement must be implicitly convertible to 'System.IDisposable'. Did you mean 'await using' rather than 'using'?";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
