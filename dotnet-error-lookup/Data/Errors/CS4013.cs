namespace dotnet_error_lookup.Data.Errors;

public class CS4013 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS4013";
    string IErrorOrWarning.Message => @"Instance of type '{0}' cannot be used inside a nested function, query expression, iterator block or async method";
    string IErrorOrWarning.Explanation => @"[original] Instance of type '{0}' cannot be used inside a nested function, query expression, iterator block or async method";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs4013";
}
