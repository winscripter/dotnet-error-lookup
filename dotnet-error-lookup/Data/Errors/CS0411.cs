namespace dotnet_error_lookup.Data.Errors;

public class CS0411 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0411";
    string IErrorOrWarning.Message => @"The type arguments for method '{0}' cannot be inferred from the usage. Try specifying the type arguments explicitly.";
    string IErrorOrWarning.Explanation => @"[original] The type arguments for method '{0}' cannot be inferred from the usage. Try specifying the type arguments explicitly.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0411";
}
