namespace dotnet_error_lookup.Data.Errors;

public class CS0406 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0406";
    string IErrorOrWarning.Message => @"The class type constraint '{0}' must come before any other constraints";
    string IErrorOrWarning.Explanation => @"[original] The class type constraint '{0}' must come before any other constraints";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0406";
}
