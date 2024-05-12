namespace dotnet_error_lookup.Data.Errors;

public class CS0213 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0213";
    string IErrorOrWarning.Message => @"You cannot use the fixed statement to take the address of an already fixed expression";
    string IErrorOrWarning.Explanation => @"[original] You cannot use the fixed statement to take the address of an already fixed expression";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0213";
}
