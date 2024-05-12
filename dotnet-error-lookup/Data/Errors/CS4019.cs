namespace dotnet_error_lookup.Data.Errors;

public class CS4019 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS4019";
    string IErrorOrWarning.Message => @"CallerMemberNameAttribute cannot be applied because there are no standard conversions from type '{0}' to type '{1}'";
    string IErrorOrWarning.Explanation => @"[original] CallerMemberNameAttribute cannot be applied because there are no standard conversions from type '{0}' to type '{1}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
