namespace dotnet_error_lookup.Data.Errors;

public class CS0254 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0254";
    string IErrorOrWarning.Message => @"The right hand side of a fixed statement assignment may not be a cast expression";
    string IErrorOrWarning.Explanation => @"[original] The right hand side of a fixed statement assignment may not be a cast expression";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0254";
}
