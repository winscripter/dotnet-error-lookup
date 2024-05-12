namespace dotnet_error_lookup.Data.Errors;

public class CS8787 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8787";
    string IErrorOrWarning.Message => @"Cannot convert method group to function pointer (Are you missing a '&'?)";
    string IErrorOrWarning.Explanation => @"[original] Cannot convert method group to function pointer (Are you missing a '&'?)";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
