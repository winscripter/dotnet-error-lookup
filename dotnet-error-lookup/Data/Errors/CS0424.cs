namespace dotnet_error_lookup.Data.Errors;

public class CS0424 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0424";
    string IErrorOrWarning.Message => @"'{0}': a class with the ComImport attribute cannot specify a base class";
    string IErrorOrWarning.Explanation => @"[original] '{0}': a class with the ComImport attribute cannot specify a base class";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0424";
}
