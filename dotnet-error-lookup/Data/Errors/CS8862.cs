namespace dotnet_error_lookup.Data.Errors;

public class CS8862 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8862";
    string IErrorOrWarning.Message => @"A constructor declared in a type with parameter list must have 'this' constructor initializer.";
    string IErrorOrWarning.Explanation => @"[original] A constructor declared in a type with parameter list must have 'this' constructor initializer.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
