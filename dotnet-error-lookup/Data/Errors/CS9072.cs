namespace dotnet_error_lookup.Data.Errors;

public class CS9072 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9072";
    string IErrorOrWarning.Message => @"A deconstruction variable cannot be declared as a ref local";
    string IErrorOrWarning.Explanation => @"[original] A deconstruction variable cannot be declared as a ref local";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
