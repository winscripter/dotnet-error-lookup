namespace dotnet_error_lookup.Data.Errors;

public class CS1032 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1032";
    string IErrorOrWarning.Message => @"Cannot define/undefine preprocessor symbols after first token in file";
    string IErrorOrWarning.Explanation => @"[original] Cannot define/undefine preprocessor symbols after first token in file";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1032";
}
