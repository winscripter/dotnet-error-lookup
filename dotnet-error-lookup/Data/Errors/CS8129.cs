namespace dotnet_error_lookup.Data.Errors;

public class CS8129 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8129";
    string IErrorOrWarning.Message => @"No suitable 'Deconstruct' instance or extension method was found for type '{0}', with {1} out parameters and a void return type.";
    string IErrorOrWarning.Explanation => @"[original] No suitable 'Deconstruct' instance or extension method was found for type '{0}', with {1} out parameters and a void return type.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8129";
}
