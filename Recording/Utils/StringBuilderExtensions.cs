using System.Text;

namespace Recording.Utils
{
	internal static class StringBuilderExtensions
	{
		private const char Separator = ';';

		internal static void AppendWithSeparator(this StringBuilder builder, string value)
		{
			builder.AppendFormat($"{value}{Separator}");
		}
	}
}
