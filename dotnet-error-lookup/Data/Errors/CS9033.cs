namespace dotnet_error_lookup.Data.Errors;

public class CS9033 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9033";
    string IErrorOrWarning.Message => @"Do not use 'System.Runtime.CompilerServices.RequiredMemberAttribute'. Use the 'required' keyword on required fields and properties instead.";
    string IErrorOrWarning.Explanation => @"[original] Do not use 'System.Runtime.CompilerServices.RequiredMemberAttribute'. Use the 'required' keyword on required fields and properties instead.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
