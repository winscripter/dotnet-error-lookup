namespace dotnet_error_lookup.Data.Errors;

public class CS8912 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8912";
    string IErrorOrWarning.Message => @"Inheriting from a record with a sealed 'Object.ToString' is not supported in C# {0}. Please use language version '{1}' or greater.";
    string IErrorOrWarning.Explanation => @"[original] Inheriting from a record with a sealed 'Object.ToString' is not supported in C# {0}. Please use language version '{1}' or greater.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/feature-version-errors";
}
