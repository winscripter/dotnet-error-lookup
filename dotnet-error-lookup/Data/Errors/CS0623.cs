namespace dotnet_error_lookup.Data.Errors;

public class CS0623 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0623";
    string IErrorOrWarning.Message => @"Array initializers can only be used in a variable or field initializer. Try using a new expression instead.";
    string IErrorOrWarning.Explanation => @"[original] Array initializers can only be used in a variable or field initializer. Try using a new expression instead.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0623";
}
