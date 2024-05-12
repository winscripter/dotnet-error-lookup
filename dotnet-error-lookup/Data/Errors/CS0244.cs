namespace dotnet_error_lookup.Data.Errors;

public class CS0244 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0244";
    string IErrorOrWarning.Message => @"Neither 'is' nor 'as' is valid on pointer types";
    string IErrorOrWarning.Explanation => @"[original] Neither 'is' nor 'as' is valid on pointer types";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0244";
}
