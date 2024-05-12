namespace dotnet_error_lookup.Data.Errors;

public class CS0400 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0400";
    string IErrorOrWarning.Message => @"The type or namespace name '{0}' could not be found in the global namespace (are you missing an assembly reference?)";
    string IErrorOrWarning.Explanation => @"[original] The type or namespace name '{0}' could not be found in the global namespace (are you missing an assembly reference?)";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0400";
}
