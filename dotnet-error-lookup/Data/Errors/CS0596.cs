namespace dotnet_error_lookup.Data.Errors;

public class CS0596 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0596";
    string IErrorOrWarning.Message => @"The Guid attribute must be specified with the ComImport attribute";
    string IErrorOrWarning.Explanation => @"[original] The Guid attribute must be specified with the ComImport attribute";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0596";
}
