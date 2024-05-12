namespace dotnet_error_lookup.Data.Errors;

public class CS8931 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8931";
    string IErrorOrWarning.Message => @"User-defined conversion in an interface must convert to or from a type parameter on the enclosing type constrained to the enclosing type";
    string IErrorOrWarning.Explanation => @"[original] User-defined conversion in an interface must convert to or from a type parameter on the enclosing type constrained to the enclosing type";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
