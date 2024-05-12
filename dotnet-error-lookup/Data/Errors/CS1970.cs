namespace dotnet_error_lookup.Data.Errors;

public class CS1970 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1970";
    string IErrorOrWarning.Message => @"Do not use 'System.Runtime.CompilerServices.DynamicAttribute'. Use the 'dynamic' keyword instead.";
    string IErrorOrWarning.Explanation => @"[original] Do not use 'System.Runtime.CompilerServices.DynamicAttribute'. Use the 'dynamic' keyword instead.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
