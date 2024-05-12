namespace dotnet_error_lookup.Data.Errors;

public class CS1528 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1528";
    string IErrorOrWarning.Message => @"Expected ; or = (cannot specify constructor arguments in declaration)";
    string IErrorOrWarning.Explanation => @"[original] Expected ; or = (cannot specify constructor arguments in declaration)";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1528";
}
