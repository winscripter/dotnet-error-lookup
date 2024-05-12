namespace dotnet_error_lookup.Data.Errors;

public class CS0706 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0706";
    string IErrorOrWarning.Message => @"Invalid constraint type. A type used as a constraint must be an interface, a non-sealed class or a type parameter.";
    string IErrorOrWarning.Explanation => @"[original] Invalid constraint type. A type used as a constraint must be an interface, a non-sealed class or a type parameter.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0706";
}
