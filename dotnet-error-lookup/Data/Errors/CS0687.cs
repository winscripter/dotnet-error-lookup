namespace dotnet_error_lookup.Data.Errors;

public class CS0687 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0687";
    string IErrorOrWarning.Message => @"The namespace alias qualifier '::' always resolves to a type or namespace so is illegal here. Consider using '.' instead.";
    string IErrorOrWarning.Explanation => @"[original] The namespace alias qualifier '::' always resolves to a type or namespace so is illegal here. Consider using '.' instead.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0687";
}
