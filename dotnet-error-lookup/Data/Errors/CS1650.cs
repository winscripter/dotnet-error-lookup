namespace dotnet_error_lookup.Data.Errors;

public class CS1650 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1650";
    string IErrorOrWarning.Message => @"Fields of static readonly field '{0}' cannot be assigned to (except in a static constructor or a variable initializer)";
    string IErrorOrWarning.Explanation => @"[original] Fields of static readonly field '{0}' cannot be assigned to (except in a static constructor or a variable initializer)";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1650";
}
