namespace dotnet_error_lookup.Data.Errors;

public class CS8372 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8372";
    string IErrorOrWarning.Message => @"Do not use 'System.Runtime.CompilerServices.FixedBuffer' attribute on a property";
    string IErrorOrWarning.Explanation => @"[original] Do not use 'System.Runtime.CompilerServices.FixedBuffer' attribute on a property";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
