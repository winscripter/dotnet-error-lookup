namespace dotnet_error_lookup.Data.Errors;

public class CS0224 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0224";
    string IErrorOrWarning.Message => @"A method with vararg cannot be generic, be in a generic type, or have a params parameter";
    string IErrorOrWarning.Explanation => @"[original] A method with vararg cannot be generic, be in a generic type, or have a params parameter";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
