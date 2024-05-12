namespace dotnet_error_lookup.Data.Errors;

public class CS0217 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0217";
    string IErrorOrWarning.Message => @"In order to be applicable as a short circuit operator a user-defined logical operator ('{0}') must have the same return type and parameter types";
    string IErrorOrWarning.Explanation => @"[original] In order to be applicable as a short circuit operator a user-defined logical operator ('{0}') must have the same return type and parameter types";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0217";
}
