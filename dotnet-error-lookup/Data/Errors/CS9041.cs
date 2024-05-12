namespace dotnet_error_lookup.Data.Errors;

public class CS9041 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9041";
    string IErrorOrWarning.Message => @"'{0}' requires compiler feature '{1}', which is not supported by this version of the C# compiler.";
    string IErrorOrWarning.Explanation => @"[original] '{0}' requires compiler feature '{1}', which is not supported by this version of the C# compiler.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
