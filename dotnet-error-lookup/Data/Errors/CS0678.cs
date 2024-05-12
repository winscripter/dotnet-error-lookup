namespace dotnet_error_lookup.Data.Errors;

public class CS0678 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0678";
    string IErrorOrWarning.Message => @"'{0}': a field cannot be both volatile and readonly";
    string IErrorOrWarning.Explanation => @"[original] '{0}': a field cannot be both volatile and readonly";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0678";
}
