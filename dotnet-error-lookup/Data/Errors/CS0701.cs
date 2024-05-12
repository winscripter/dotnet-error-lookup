namespace dotnet_error_lookup.Data.Errors;

public class CS0701 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0701";
    string IErrorOrWarning.Message => @"'{0}' is not a valid constraint. A type used as a constraint must be an interface, a non-sealed class or a type parameter.";
    string IErrorOrWarning.Explanation => @"[original] '{0}' is not a valid constraint. A type used as a constraint must be an interface, a non-sealed class or a type parameter.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0701";
}
