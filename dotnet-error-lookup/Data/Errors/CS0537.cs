namespace dotnet_error_lookup.Data.Errors;

public class CS0537 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0537";
    string IErrorOrWarning.Message => @"The class System.Object cannot have a base class or implement an interface";
    string IErrorOrWarning.Explanation => @"[original] The class System.Object cannot have a base class or implement an interface";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0537";
}
