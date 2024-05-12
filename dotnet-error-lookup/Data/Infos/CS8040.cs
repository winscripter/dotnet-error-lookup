namespace dotnet_error_lookup.Data.Errors;

public class CS8040 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Information;
    string IErrorOrWarning.Name => @"CS8040";
    string IErrorOrWarning.Message => @"Skipping some types in analyzer assembly {0} due to a ReflectionTypeLoadException : {1}.";
    string IErrorOrWarning.Explanation => @"[original] Skipping some types in analyzer assembly {0} due to a ReflectionTypeLoadException : {1}.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
