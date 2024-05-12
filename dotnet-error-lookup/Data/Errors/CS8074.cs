namespace dotnet_error_lookup.Data.Errors;

public class CS8074 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8074";
    string IErrorOrWarning.Message => @"An expression tree lambda may not contain a dictionary initializer.";
    string IErrorOrWarning.Explanation => @"[original] An expression tree lambda may not contain a dictionary initializer.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
