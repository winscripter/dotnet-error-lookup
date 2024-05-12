namespace dotnet_error_lookup.Data.Errors;

public class CS0200 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0200";
    string IErrorOrWarning.Message => @"Property or indexer '{0}' cannot be assigned to -- it is read only";
    string IErrorOrWarning.Explanation => @"[original] Property or indexer '{0}' cannot be assigned to -- it is read only";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0200";
}
