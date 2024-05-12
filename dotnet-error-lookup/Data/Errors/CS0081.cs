namespace dotnet_error_lookup.Data.Errors;

public class CS0081 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0081";
    string IErrorOrWarning.Message => @"Type parameter declaration must be an identifier not a type";
    string IErrorOrWarning.Explanation => @"[original] Type parameter declaration must be an identifier not a type";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0081";
}
