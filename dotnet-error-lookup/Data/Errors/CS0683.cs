namespace dotnet_error_lookup.Data.Errors;

public class CS0683 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0683";
    string IErrorOrWarning.Message => @"'{0}' explicit method implementation cannot implement '{1}' because it is an accessor";
    string IErrorOrWarning.Explanation => @"[original] '{0}' explicit method implementation cannot implement '{1}' because it is an accessor";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0683";
}
