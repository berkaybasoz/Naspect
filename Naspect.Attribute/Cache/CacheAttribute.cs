﻿using Naspect.Core.Arg;
using Naspect.Core.Attribute;
using Naspect.Core.Cache;
using Naspect.Core.Container;
using Naspect.Core.Interception;

namespace Naspect.Attribute.Cache
{
    public class CacheAttribute : InterceptAttribute, IPreInterception, IPostVoidInterception
    {
        private readonly ICacheProvider cacheProvider;

        public int DurationInMinute { get; set; }

        public CacheAttribute()
        {
            cacheProvider = ContainerContext.Resolve<ICacheProvider>();
        }

        public object OnPre(PreInterceptArgs e)
        {
            // gerekli cache key ile kontrol ederek varsa cache'de çağırım öncesi metot'u execute
            // etmeden cache üzerinden ilgili veriyi geri dön.
            string cacheKey = string.Format("{0}_{1}", e.MethodName, string.Join("_", e.Arguments));
            object data;
            if (cacheProvider.TryGetData(cacheKey, out data))
            {
                //Proxy içinde esas metodu çalıştırma ben cache üzerinde veri buldum bu veriyi dön diyoruz
                e.OverrideReturnValue = true;
            }
            return data;
        }

        public void OnPost(PostInterceptArgs e)
        {
            //key ile veriyi cache'e ekle yada güncelle.
            string cacheKey = string.Format("{0}_{1}", e.MethodName, string.Join("_", e.Arguments));
            cacheProvider.SetData(cacheKey, e.Value);
        }
    }
}
