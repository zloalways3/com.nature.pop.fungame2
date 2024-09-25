using System;
using System.Collections.Generic;
using NVjknvKJDw.NJasnakjdqwe;
using VNjanskdjq;
using UnityEngine;

namespace NVjknvKJDw
{
    public class NljNSKJndjkq : MonoBehaviour
    {
         [SerializeField] private IJlSANOq jlSanOq;
         [SerializeField] private PjOInoeiqw1 pjOInoeiqw1;
         [SerializeField] private NoiNOIqwepovr noiNoIqwepovr;
         [SerializeField] private NjkvnejkNqw njkvnejkNqw;
         [SerializeField] private POIubNPOwhequo poIubNpOwhequo;

        private Dictionary<Type, JIOdOIqweoiNOIq> vnjtrknkjq;
        private JIOdOIqweoiNOIq kjuivbtrn3o;
        private JIOdOIqweoiNOIq nvjnrknkj;
        private NjknKJnqwke qmvkjtrnkj;

        private void Start()
        {
            vnjtrknkjq = new Dictionary<Type, JIOdOIqweoiNOIq>()
            {
                { typeof(IJlSANOq), jlSanOq },
                { typeof(PjOInoeiqw1), pjOInoeiqw1 },
                { typeof(NoiNOIqwepovr), noiNoIqwepovr },
                { typeof(NjkvnejkNqw), njkvnejkNqw },
                { typeof(POIubNPOwhequo), poIubNpOwhequo },
            };
        }

        public void NMnjanksdj1(NjknKJnqwke njknKJnqwke)
        {
            qmvkjtrnkj = njknKJnqwke;

            var klkqwjkel = njknKJnqwke.BHbkqwbekj1<POIUbqnwqnoi1>();
            var bnjtkrnjk23 = njknKJnqwke.BHbkqwbekj1<POHIqwepIho123>();

            foreach (var qinv5j in vnjtrknkjq)
            {
                qinv5j.Value.PouJNqncui3(this, bnjtkrnjk23);
            }

            poIubNpOwhequo.POnoILNawoeq(klkqwjkel);
            jlSanOq.OInajknjkew(klkqwjkel);
            noiNoIqwepovr.psmdvtroi(klkqwjkel);
            njkvnejkNqw.BiabKJbkjqwe1();
        }

        public void INJNKJasd1()
        {
            NjkNLKasnelqk<PjOInoeiqw1>();
            pjOInoeiqw1.OMMnmalks();
        }

        public void NjkNLKasnelqk<NlkNAKsjdq>() where NlkNAKsjdq : JIOdOIqweoiNOIq
        {
            kjuivbtrn3o = nvjnrknkj;
            kjuivbtrn3o?.hJPOhuIqwe();
            nvjnrknkj = vnjtrknkjq[typeof(NlkNAKsjdq)];
            nvjnrknkj.POubjnPOiuqgwienvio();
        }

        public void NjkNLKasnelqk<JBKBKJdqw, YBqowueho1i>(YBqowueho1i NKVnlreknlk2) where JBKBKJdqw : JIOdOIqweoiNOIq
        {
            ((LKNvjknjqkwe<YBqowueho1i>)vnjtrknkjq[typeof(JBKBKJdqw)]).POIjKKUYqkwe(NKVnlreknlk2);
            NjkNLKasnelqk<JBKBKJdqw>();
        }

        public void IjoiqweOIwe1()
        {
            if (kjuivbtrn3o is null)
                return;

            nvjnrknkj.hJPOhuIqwe();
            kjuivbtrn3o.POubjnPOiuqgwienvio();

            (kjuivbtrn3o, nvjnrknkj) = (nvjnrknkj, kjuivbtrn3o);
        }
    }
}