namespace dotnet_error_lookup.Data.Errors;

public class CS0825 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0825";
    string IErrorOrWarning.Message => @"The contextual keyword 'var' may only appear within a local variable declaration or in script code";
    string IErrorOrWarning.Explanation => @"[original] The contextual keyword 'var' may only appear within a local variable declaration or in script code";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0825";
}
