namespace dotnet_error_lookup.Data.Errors;

public class CS0126 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0126";
    string IErrorOrWarning.Message => @"An object of a type convertible to '{0}' is required";
    string IErrorOrWarning.Explanation => @"[original] An object of a type convertible to '{0}' is required";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0126";
}
