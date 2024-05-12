namespace dotnet_error_lookup.Data.Errors;

public class CS8054 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8054";
    string IErrorOrWarning.Message => @"Enums cannot contain explicit parameterless constructors";
    string IErrorOrWarning.Explanation => @"[original] Enums cannot contain explicit parameterless constructors";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
