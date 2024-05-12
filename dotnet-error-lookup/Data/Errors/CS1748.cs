namespace dotnet_error_lookup.Data.Errors;

public class CS1748 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1748";
    string IErrorOrWarning.Message => @"Cannot find the interop type that matches the embedded interop type '{0}'. Are you missing an assembly reference?";
    string IErrorOrWarning.Explanation => @"[original] Cannot find the interop type that matches the embedded interop type '{0}'. Are you missing an assembly reference?";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
