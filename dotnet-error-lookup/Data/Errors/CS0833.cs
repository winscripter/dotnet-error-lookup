namespace dotnet_error_lookup.Data.Errors;

public class CS0833 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0833";
    string IErrorOrWarning.Message => @"An anonymous type cannot have multiple properties with the same name";
    string IErrorOrWarning.Explanation => @"[original] An anonymous type cannot have multiple properties with the same name";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0833";
}
