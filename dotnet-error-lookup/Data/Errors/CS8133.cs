namespace dotnet_error_lookup.Data.Errors;

public class CS8133 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8133";
    string IErrorOrWarning.Message => @"Cannot deconstruct dynamic objects.";
    string IErrorOrWarning.Explanation => @"[original] Cannot deconstruct dynamic objects.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
