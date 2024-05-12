namespace dotnet_error_lookup.Data.Errors;

public class CS8346 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8346";
    string IErrorOrWarning.Message => @"Conversion of a stackalloc expression of type '{0}' to type '{1}' is not possible.";
    string IErrorOrWarning.Explanation => @"[original] Conversion of a stackalloc expression of type '{0}' to type '{1}' is not possible.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
