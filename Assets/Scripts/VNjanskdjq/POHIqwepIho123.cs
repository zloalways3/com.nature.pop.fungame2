using UnityEngine;

namespace VNjanskdjq
{
    public class POHIqwepIho123 : MonoBehaviour
    {
        private const string POOHUOw123 = "HIoIHoiqwe1";
        private const string POIUGboqpwe = "amsodjoiwe";

         [SerializeField] private AudioSource OPYvhbpq;
         [SerializeField] private AudioSource KNBVioipqowe1;
         [SerializeField] private AudioSource nioqwpoej1;
         [SerializeField] private AudioSource MPoqwejPO123;
         [SerializeField] private AudioSource HJpoqwiogeu1o;
        
        public bool HJKhGYUIKj { get; set; }

        public bool NPiqweNPI
        {
            get => OPYvhbpq.mute;
            set => OPYvhbpq.mute = value;
        }

        private void Start()
        {
            if (!PlayerPrefs.HasKey(POOHUOw123))
                PlayerPrefs.SetInt(POOHUOw123, NPiqweNPI ? 1 : 0);
            
            if (!PlayerPrefs.HasKey(POIUGboqpwe))
                PlayerPrefs.SetInt(POIUGboqpwe, HJKhGYUIKj ? 1 : 0);

            NPiqweNPI = PlayerPrefs.GetInt(POOHUOw123) == 1;
            HJKhGYUIKj = PlayerPrefs.GetInt(POIUGboqpwe) == 1;
        }

        public void BHjNBGyujGYuj()
        {
            if (HJKhGYUIKj)
                return;
            
            KNBVioipqowe1.Play();
        }

        public void HjkNBGYujGyu()
        {
            if (HJKhGYUIKj)
                return;

            HJpoqwiogeu1o.Play();
        }

        public void PoqjwePO12()
        {
            if (HJKhGYUIKj)
                return;

            nioqwpoej1.Play();
        }
        
        public void PinqwPonpeqw()
        {
            if (HJKhGYUIKj)
                return;

            MPoqwejPO123.Play();
        }

        public void NoiNOqwenOI()
        {
            OPYvhbpq.Play();
        }
    }
}