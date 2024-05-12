namespace dotnet_error_lookup.Data.Errors;

public class CS0271 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0271";
    string IErrorOrWarning.Message => @"The property or indexer '{0}' cannot be used in this context because the get accessor is inaccessible";
    string IErrorOrWarning.Explanation => @"[original] The property or indexer '{0}' cannot be used in this context because the get accessor is inaccessible";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0271";
}
