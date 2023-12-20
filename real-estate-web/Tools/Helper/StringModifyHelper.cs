using System.Globalization;

namespace real_estate_web.Tools.Helper
{
    public static class StringModifyHelper
    {
        public static string FirstCharUpper(this string str)
        {

            string newString = string.Empty;
            foreach (var item in str.Split(" "))
            {
                for (int i = 0; i < item.Length; i++)
                {
                    if (i == 0)
                    {
                        newString += item[i].ToString().ToUpper(CultureInfo.CreateSpecificCulture("tr-TR"));
                        continue;
                    }
                    newString += item[i].ToString().ToLower(CultureInfo.CreateSpecificCulture("tr-TR"));
                }
                newString += " ";
            }


            return newString.Trim();
        }

        public static string TitleToUrl(this string str)
        {
            string newStr = string.Empty;
            str = str.ToLower(CultureInfo.CreateSpecificCulture("en-US"));
            newStr = str.Replace(" ", "-").Replace("+","").Replace("'","").Replace(".","").Replace(",","")
                .Replace("ç","c")
                .Replace("ş","s")
                .Replace("ö","o")
                .Replace("ü","u")
                .Replace("ı","i")
                .Replace("ğ","g");
            return newStr;
        }
    }
}
