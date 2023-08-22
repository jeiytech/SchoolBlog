using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBlog.CustomText
{
    public class TruncateConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string text = value?.ToString();
            if (string.IsNullOrEmpty(text))
                return string.Empty;

            const int maxLines = 2;
            const int maxLength = 3;
            const string ellipsis = "...";

            var lines = text.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            if (lines.Length > maxLines)
            {
                var truncatedText = lines.Take(maxLines).ToList();
                truncatedText[maxLines - 1] = truncatedText[maxLines - 1].Substring(0, truncatedText[maxLines - 1].Length - maxLength) + ellipsis;
                return string.Join(Environment.NewLine, truncatedText);
            }

            return text;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
