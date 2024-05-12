namespace dotnet_error_lookup.Data.Errors;

public class CS0412 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0412";
    string IErrorOrWarning.Message => @"'{0}': a parameter, local variable, or local function cannot have the same name as a method type parameter";
    string IErrorOrWarning.Explanation => @"[original] '{0}': a parameter, local variable, or local function cannot have the same name as a method type parameter";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0412";
}
