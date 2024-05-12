namespace dotnet_error_lookup.Data.Errors;

public class CS0077 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0077";
    string IErrorOrWarning.Message => @"The as operator must be used with a reference type or nullable type ('{0}' is a non-nullable value type)";
    string IErrorOrWarning.Explanation => @"[original] The as operator must be used with a reference type or nullable type ('{0}' is a non-nullable value type)";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0077";
}
