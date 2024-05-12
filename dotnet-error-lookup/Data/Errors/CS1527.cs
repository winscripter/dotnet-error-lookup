namespace dotnet_error_lookup.Data.Errors;

public class CS1527 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1527";
    string IErrorOrWarning.Message => @"Elements defined in a namespace cannot be explicitly declared as private, protected, protected internal, or private protected";
    string IErrorOrWarning.Explanation => @"[original] Elements defined in a namespace cannot be explicitly declared as private, protected, protected internal, or private protected";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1527";
}
