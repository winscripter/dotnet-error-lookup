namespace dotnet_error_lookup.Data.Errors;

public class CS8703 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8703";
    string IErrorOrWarning.Message => @"The modifier '{0}' is not valid for this item in C# {1}. Please use language version '{2}' or greater.";
    string IErrorOrWarning.Explanation => @"[original] The modifier '{0}' is not valid for this item in C# {1}. Please use language version '{2}' or greater.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/feature-version-errors";
}
