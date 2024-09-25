using VNjanskdjq;
using UnityEngine;
using UnityEngine.UI;

namespace NVjknvKJDw.NJasnakjdqwe
{
    public class POIubNPOwhequo : JIOdOIqweoiNOIq
    {
         [SerializeField] private Button[] Nklnfrenklnlkqw1;
        
        private POIUbqnwqnoi1 _poiUbqnwqnoi1;

        private void Start()
        {
            for (int i = 0; i < Nklnfrenklnlkqw1.Length; ++i)
            {
                var t = i;
                Nklnfrenklnlkqw1[i].onClick.AddListener(() => BoJOIqwoi(t));
            }
        }

        public void POnoILNawoeq(
            POIUbqnwqnoi1 poiUbqnwqnoi1
        )
        {
            _poiUbqnwqnoi1 = poiUbqnwqnoi1;
            PjaOINwoeiq1();
        }
        
        public void BoJOIqwoi(int Mklamdqowije)
        {
            PohIqwepIho123.BHjNBGyujGYuj();
            nfdiowenroi.NjkNLKasnelqk<NoiNOIqwepovr, PinOILhwonei>(new PinOILhwonei { NVklewnlk1 = Mklamdqowije });
        }
        
        public override void POubjnPOiuqgwienvio()
        {
            PjaOINwoeiq1();
            
            base.POubjnPOiuqgwienvio();
        }
        
        private void PjaOINwoeiq1()
        {
            for (int i = 0; i < Nklnfrenklnlkqw1.Length; ++i)
            {
                Nklnfrenklnlkqw1[i].interactable = i <= _poiUbqnwqnoi1.POOYvhbopqowe;
            }
        }
    }
}