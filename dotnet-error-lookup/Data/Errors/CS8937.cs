namespace dotnet_error_lookup.Data.Errors;

public class CS8937 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8937";
    string IErrorOrWarning.Message => @"At least one top-level statement must be non-empty.";
    string IErrorOrWarning.Explanation => @"[original] At least one top-level statement must be non-empty.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
