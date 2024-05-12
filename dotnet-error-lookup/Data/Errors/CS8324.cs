namespace dotnet_error_lookup.Data.Errors;

public class CS8324 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8324";
    string IErrorOrWarning.Message => @"Named argument specifications must appear after all fixed arguments have been specified in a dynamic invocation.";
    string IErrorOrWarning.Explanation => @"[original] Named argument specifications must appear after all fixed arguments have been specified in a dynamic invocation.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
