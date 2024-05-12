namespace dotnet_error_lookup.Data.Errors;

public class CS0068 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0068";
    string IErrorOrWarning.Message => @"'{0}': instance event in interface cannot have initializer";
    string IErrorOrWarning.Explanation => @"[original] '{0}': instance event in interface cannot have initializer";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0068";
}
