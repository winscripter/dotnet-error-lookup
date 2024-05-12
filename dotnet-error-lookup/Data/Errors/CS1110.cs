namespace dotnet_error_lookup.Data.Errors;

public class CS1110 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1110";
    string IErrorOrWarning.Message => @"Cannot define a new extension method because the compiler required type '{0}' cannot be found. Are you missing a reference to System.Core.dll?";
    string IErrorOrWarning.Explanation => @"[original] Cannot define a new extension method because the compiler required type '{0}' cannot be found. Are you missing a reference to System.Core.dll?";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1110";
}
