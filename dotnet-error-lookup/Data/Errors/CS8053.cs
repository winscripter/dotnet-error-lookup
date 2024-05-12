namespace dotnet_error_lookup.Data.Errors;

public class CS8053 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8053";
    string IErrorOrWarning.Message => @"Instance properties in interfaces cannot have initializers.";
    string IErrorOrWarning.Explanation => @"[original] Instance properties in interfaces cannot have initializers.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
