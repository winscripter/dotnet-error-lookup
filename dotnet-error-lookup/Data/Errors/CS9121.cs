namespace dotnet_error_lookup.Data.Errors;

public class CS9121 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9121";
    string IErrorOrWarning.Message => @"Struct primary constructor parameter '{0}' of type '{1}' causes a cycle in the struct layout";
    string IErrorOrWarning.Explanation => @"[original] Struct primary constructor parameter '{0}' of type '{1}' causes a cycle in the struct layout";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
