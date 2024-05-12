namespace dotnet_error_lookup.Data.Errors;

public class CS8344 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8344";
    string IErrorOrWarning.Message => @"foreach statement cannot operate on enumerators of type '{0}' in async or iterator methods because '{0}' is a ref struct.";
    string IErrorOrWarning.Explanation => @"[original] foreach statement cannot operate on enumerators of type '{0}' in async or iterator methods because '{0}' is a ref struct.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
