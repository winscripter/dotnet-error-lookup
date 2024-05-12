namespace dotnet_error_lookup.Data.Errors;

public class CS0673 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0673";
    string IErrorOrWarning.Message => @"System.Void cannot be used from C# -- use typeof(void) to get the void type object";
    string IErrorOrWarning.Explanation => @"[original] System.Void cannot be used from C# -- use typeof(void) to get the void type object";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0673";
}
