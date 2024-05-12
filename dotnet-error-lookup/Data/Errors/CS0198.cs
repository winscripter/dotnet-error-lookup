namespace dotnet_error_lookup.Data.Errors;

public class CS0198 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0198";
    string IErrorOrWarning.Message => @"A static readonly field cannot be assigned to (except in a static constructor or a variable initializer)";
    string IErrorOrWarning.Explanation => @"[original] A static readonly field cannot be assigned to (except in a static constructor or a variable initializer)";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0198";
}
