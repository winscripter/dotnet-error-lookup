namespace dotnet_error_lookup.Data.Errors;

public class CS1556 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1556";
    string IErrorOrWarning.Message => @"'{0}' specified for Main method must be a non-generic class, record, struct, or interface";
    string IErrorOrWarning.Explanation => @"[original] '{0}' specified for Main method must be a non-generic class, record, struct, or interface";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1556";
}
