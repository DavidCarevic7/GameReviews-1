using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Help
{
    public class ImageFormatCheck
    {
        public static IEnumerable<string> AllowedExtensions => new List<string> { ".jpeg", ".jpg", ".gif", ".png" };
    }
}
