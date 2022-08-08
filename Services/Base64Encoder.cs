using System.Text;

namespace AspNet6CrashCourse.Services;

public class Base64Encoder
{
    public string Encode(string value)
    {
        var bytes = Encoding.UTF8.GetBytes(value);
        return Convert.ToBase64String(bytes);
    }

    public string Decode(string value)
    {
        var bytes = Convert.FromBase64String(value);
        return Encoding.UTF8.GetString(bytes);
    }
}