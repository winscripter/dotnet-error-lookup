namespace dotnet_error_lookup.Data.Errors;

public class CS2034 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS2034";
    string IErrorOrWarning.Message => @"A /reference option that declares an extern alias can only have one filename. To specify multiple aliases or filenames, use multiple /reference options.";
    string IErrorOrWarning.Explanation => @"[original] A /reference option that declares an extern alias can only have one filename. To specify multiple aliases or filenames, use multiple /reference options.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs2034";
}
