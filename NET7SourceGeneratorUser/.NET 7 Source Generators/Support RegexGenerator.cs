using System.Text.RegularExpressions;

public partial class SupportRegexGenerator
{
	[GeneratedRegex(
		@"^(ht|f)tp(s?)\:\/\/[0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*(:(0-9)*)*(\/?)([a-zA-Z0-9\-\.\?\,\'\/\\\+&amp;%\$#_]*)?$",
		RegexOptions.CultureInvariant,
		500)]
	private static partial Regex MatchIfValidUrl();

	public static bool IsValidUrl(string url)
	{
		var regex = new Regex(@"\G(\d{1,3})((?=(?:\d{3})+$))", RegexOptions.IgnoreCase);
        
		return MatchIfValidUrl().IsMatch(url);
	}
}
