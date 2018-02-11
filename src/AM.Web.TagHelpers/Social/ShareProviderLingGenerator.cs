using System;
using System.Collections.Generic;
using System.Text;

namespace AM.Web.TagHelpers.Social
{
    internal class ShareProviderLingGenerator
    {
        private static IDictionary<ShareProvider, string> providerLinkMap = new Dictionary<ShareProvider, string>
        {
            {ShareProvider.Digg, "http://www.digg.com/submit?url={0}" },
            {ShareProvider.Email, "mailto:?Body={0}" },
            {ShareProvider.Facebook, "http://www.facebook.com/sharer.php?u={0}" },
            {ShareProvider.GooglePlus, "https://plus.google.com/share?url={0}" },
            {ShareProvider.LinkedIn, "http://www.linkedin.com/shareArticle?mini=true&amp;url={0}" },
            {ShareProvider.Pinterest, "javascript:void((function()%7Bvar%20e=document.createElement('script');e.setAttribute('type','text/javascript');e.setAttribute('charset','UTF-8');e.setAttribute('src','http://assets.pinterest.com/js/pinmarklet.js?r='+Math.random()*99999999);document.body.appendChild(e)%7D)());" },
            {ShareProvider.Reddit, "http://reddit.com/submit?url={0}" },
            {ShareProvider.StumbleUpon, "http://www.stumbleupon.com/submit?url={0}" },
            {ShareProvider.Tumblr, "http://www.tumblr.com/share/link?url={0}" },
            {ShareProvider.Twitter, "https://twitter.com/share?url={0}" },
            {ShareProvider.VKontakte, "http://vkontakte.ru/share.php?url={0}" }
        };

        public string GetUrlForShareProvider(ShareProvider provider)
        {
            string result = null;
            providerLinkMap.TryGetValue(provider, out result);

            return result;
        }
    }
}
