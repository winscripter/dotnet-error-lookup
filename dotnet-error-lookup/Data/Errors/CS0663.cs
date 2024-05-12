namespace dotnet_error_lookup.Data.Errors;

public class CS0663 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0663";
    string IErrorOrWarning.Message => @"'{0}' cannot define an overloaded {1} that differs only on parameter modifiers '{2}' and '{3}'";
    string IErrorOrWarning.Explanation => @"[original] '{0}' cannot define an overloaded {1} that differs only on parameter modifiers '{2}' and '{3}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0663";
}
