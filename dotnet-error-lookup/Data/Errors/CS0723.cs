namespace dotnet_error_lookup.Data.Errors;

public class CS0723 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0723";
    string IErrorOrWarning.Message => @"Cannot declare a variable of static type '{0}'";
    string IErrorOrWarning.Explanation => @"[original] Cannot declare a variable of static type '{0}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0723";
}
