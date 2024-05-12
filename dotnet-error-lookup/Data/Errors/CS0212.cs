namespace dotnet_error_lookup.Data.Errors;

public class CS0212 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0212";
    string IErrorOrWarning.Message => @"You can only take the address of an unfixed expression inside of a fixed statement initializer";
    string IErrorOrWarning.Explanation => @"[original] You can only take the address of an unfixed expression inside of a fixed statement initializer";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0212";
}
