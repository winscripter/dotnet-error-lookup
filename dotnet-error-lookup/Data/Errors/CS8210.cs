namespace dotnet_error_lookup.Data.Errors;

public class CS8210 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8210";
    string IErrorOrWarning.Message => @"A tuple may not contain a value of type 'void'.";
    string IErrorOrWarning.Explanation => @"[original] A tuple may not contain a value of type 'void'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8210";
}
