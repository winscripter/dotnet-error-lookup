namespace dotnet_error_lookup.Data.Errors;

public class CS0413 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0413";
    string IErrorOrWarning.Message => @"The type parameter '{0}' cannot be used with the 'as' operator because it does not have a class type constraint nor a 'class' constraint";
    string IErrorOrWarning.Explanation => @"[original] The type parameter '{0}' cannot be used with the 'as' operator because it does not have a class type constraint nor a 'class' constraint";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0413";
}
