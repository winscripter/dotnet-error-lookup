namespace dotnet_error_lookup.Data.Errors;

public class CS2021 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Fatal;
    string IErrorOrWarning.Name => @"CS2021";
    string IErrorOrWarning.Message => @"File name '{0}' is empty, contains invalid characters, has a drive specification without an absolute path, or is too long";
    string IErrorOrWarning.Explanation => @"[original] File name '{0}' is empty, contains invalid characters, has a drive specification without an absolute path, or is too long";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs2021";
}
