namespace dotnet_error_lookup.Data.Errors;

public class CS0440 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS0440";
    string IErrorOrWarning.Message => @"Defining an alias named 'global' is ill-advised since 'global::' always references the global namespace and not an alias";
    string IErrorOrWarning.Explanation => @"[original] Defining an alias named 'global' is ill-advised since 'global::' always references the global namespace and not an alias";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0440";
}
