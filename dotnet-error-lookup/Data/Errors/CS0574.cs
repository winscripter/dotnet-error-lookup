namespace dotnet_error_lookup.Data.Errors;

public class CS0574 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0574";
    string IErrorOrWarning.Message => @"Name of destructor must match name of type";
    string IErrorOrWarning.Explanation => @"[original] Name of destructor must match name of type";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0574";
}
