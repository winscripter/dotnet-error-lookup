namespace dotnet_error_lookup.Data.Errors;

public class CS0250 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0250";
    string IErrorOrWarning.Message => @"Do not directly call your base type Finalize method. It is called automatically from your destructor.";
    string IErrorOrWarning.Explanation => @"[original] Do not directly call your base type Finalize method. It is called automatically from your destructor.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0250";
}
