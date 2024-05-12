namespace dotnet_error_lookup.Data.Errors;

public class CS8030 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8030";
    string IErrorOrWarning.Message => @"Anonymous function converted to a void returning delegate cannot return a value";
    string IErrorOrWarning.Explanation => @"[original] Anonymous function converted to a void returning delegate cannot return a value";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
