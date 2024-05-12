namespace dotnet_error_lookup.Data.Errors;

public class CS1507 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1507";
    string IErrorOrWarning.Message => @"Cannot link resource files when building a module";
    string IErrorOrWarning.Explanation => @"[original] Cannot link resource files when building a module";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1507";
}
