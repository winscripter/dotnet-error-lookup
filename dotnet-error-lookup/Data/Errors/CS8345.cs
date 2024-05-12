namespace dotnet_error_lookup.Data.Errors;

public class CS8345 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8345";
    string IErrorOrWarning.Message => @"Field or auto-implemented property cannot be of type '{0}' unless it is an instance member of a ref struct.";
    string IErrorOrWarning.Explanation => @"[original] Field or auto-implemented property cannot be of type '{0}' unless it is an instance member of a ref struct.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
