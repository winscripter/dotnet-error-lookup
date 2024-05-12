namespace dotnet_error_lookup.Data.Errors;

public class CS8711 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8711";
    string IErrorOrWarning.Message => @"Type '{0}' cannot be embedded because it has a non-abstract member. Consider setting the 'Embed Interop Types' property to false.";
    string IErrorOrWarning.Explanation => @"[original] Type '{0}' cannot be embedded because it has a non-abstract member. Consider setting the 'Embed Interop Types' property to false.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
