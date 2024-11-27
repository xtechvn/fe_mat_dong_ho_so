using Microsoft.AspNetCore.Mvc.Rendering;

namespace NewSolution.Utilities
{
    public static  class StaticImageHelper
    {
        public static string GetStaticImageUrl(this IHtmlHelper htmlHelper, string imagePath, IConfiguration configuration)
        {
            var baseUrl = configuration["common:link_static_img"];
            return $"{baseUrl}/{imagePath}";
        }
    }
}
