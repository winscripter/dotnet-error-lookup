namespace dotnet_error_lookup.Data.Errors;

public class CS9104 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9104";
    string IErrorOrWarning.Message => @"A using statement resource of type '{0}' cannot be used in async methods or async lambda expressions.";
    string IErrorOrWarning.Explanation => @"[original] A using statement resource of type '{0}' cannot be used in async methods or async lambda expressions.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
