namespace dotnet_error_lookup.Data.Errors;

public class CS0261 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0261";
    string IErrorOrWarning.Message => @"Partial declarations of '{0}' must be all classes, all record classes, all structs, all record structs, or all interfaces";
    string IErrorOrWarning.Explanation => @"[original] Partial declarations of '{0}' must be all classes, all record classes, all structs, all record structs, or all interfaces";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0261";
}
