namespace dotnet_error_lookup.Data.Errors;

public class CS8096 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8096";
    string IErrorOrWarning.Message => @"Debug entry point must be a definition of a method declared in the current compilation.";
    string IErrorOrWarning.Explanation => @"[original] Debug entry point must be a definition of a method declared in the current compilation.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
