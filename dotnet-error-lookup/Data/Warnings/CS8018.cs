namespace dotnet_error_lookup.Data.Errors;

public class CS8018 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8018";
    string IErrorOrWarning.Message => @"Within cref attributes, nested types of generic types should be qualified.";
    string IErrorOrWarning.Explanation => @"[original] Within cref attributes, nested types of generic types should be qualified.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
