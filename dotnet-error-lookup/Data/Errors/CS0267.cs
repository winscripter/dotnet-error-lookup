namespace dotnet_error_lookup.Data.Errors;

public class CS0267 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0267";
    string IErrorOrWarning.Message => @"The 'partial' modifier can only appear immediately before 'class', 'record', 'struct', 'interface', or a method return type.";
    string IErrorOrWarning.Explanation => @"[original] The 'partial' modifier can only appear immediately before 'class', 'record', 'struct', 'interface', or a method return type.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0267";
}
