namespace dotnet_error_lookup.Data.Errors;

public class CS0458 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS0458";
    string IErrorOrWarning.Message => @"The result of the expression is always 'null' of type '{0}'";
    string IErrorOrWarning.Explanation => @"[original] The result of the expression is always 'null' of type '{0}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0458";
}
