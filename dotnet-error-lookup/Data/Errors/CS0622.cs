namespace dotnet_error_lookup.Data.Errors;

public class CS0622 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0622";
    string IErrorOrWarning.Message => @"Can only use array initializer expressions to assign to array types. Try using a new expression instead.";
    string IErrorOrWarning.Explanation => @"[original] Can only use array initializer expressions to assign to array types. Try using a new expression instead.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0622";
}
