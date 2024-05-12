namespace dotnet_error_lookup.Data.Errors;

public class CS0674 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0674";
    string IErrorOrWarning.Message => @"Do not use 'System.ParamArrayAttribute'. Use the 'params' keyword instead.";
    string IErrorOrWarning.Explanation => @"[original] Do not use 'System.ParamArrayAttribute'. Use the 'params' keyword instead.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0674";
}
