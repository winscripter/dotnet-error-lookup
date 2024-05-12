namespace dotnet_error_lookup.Data.Errors;

public class CS9009 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9009";
    string IErrorOrWarning.Message => @"String must start with quote character: """;
    string IErrorOrWarning.Explanation => @"[original] String must start with quote character: """;
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
