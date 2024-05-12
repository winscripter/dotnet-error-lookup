namespace dotnet_error_lookup.Data.Errors;

public class CS0176 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0176";
    string IErrorOrWarning.Message => @"Member '{0}' cannot be accessed with an instance reference; qualify it with a type name instead";
    string IErrorOrWarning.Explanation => @"[original] Member '{0}' cannot be accessed with an instance reference; qualify it with a type name instead";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0176";
}
