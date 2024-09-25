using System;
using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

namespace NJKvnkjerk45
{
    public class OOIUGIYbenpqwooiguiy : MonoBehaviour, IPointerClickHandler
    {
        [SerializeField] private int fbyuewoqr;
        [SerializeField] private float IHUIdbqwohguitr = 0.85f;
        
        public int Fbyuewoqr => fbyuewoqr;

        private Vector2 MNIoirehoifvnrpt;
        private bool nvooqpwj31 = false;
        private bool botrhoi451 = false;
        private float bmnoitrhpwoj4325;

        public event Action<OOIUGIYbenpqwooiguiy> NBHuipqwpojeoi12;


        public void HgpowqwpejOIje(float NBiopowejor)
        {
            nvooqpwj31 = true;
            bmnoitrhpwoj4325 = NBiopowejor;
            StartCoroutine(BIUdiw312obijv(NBiopowejor));
        }

        private IEnumerator BIUdiw312obijv(float vbuierbuiqwe)
        {
            Vector3 vnuieroho = transform.localPosition;
            float sdmvirtqwe = 0;

            while (sdmvirtqwe <= vbuierbuiqwe)
            {
                sdmvirtqwe += Time.deltaTime;
                transform.localPosition = vnuieroho * (1 - sdmvirtqwe / vbuierbuiqwe);

                yield return null;
            }

            transform.localPosition = Vector3.zero;
            nvooqpwj31 = false;
        }

        public void OnDisable()
        {
            if (botrhoi451)
                Destroy(gameObject);
        }

        public void NBIOpoqwjeiuiv(float NUIhfqiwejp)
        {
            botrhoi451 = true;
            bmnoitrhpwoj4325 = NUIhfqiwejp;
            StartCoroutine(BHUoqwhoigftyf(NUIhfqiwejp));
        }

        private IEnumerator BHUoqwhoigftyf(float vhpwoejrpi)
        {
            float BGYUqwojieuy = 0;

            while (BGYUqwojieuy <= vhpwoejrpi)
            {
                BGYUqwojieuy += Time.deltaTime;
                transform.localScale = Vector3.one * (IHUIdbqwohguitr * (1 - BGYUqwojieuy / vhpwoejrpi));

                yield return null;
            }
            
            Destroy(gameObject);
            botrhoi451 = false;
        }

        public void BGHopqwhiegyu()
        {
            if (nvooqpwj31)
                HgpowqwpejOIje(bmnoitrhpwoj4325);

            if (botrhoi451)
                NBIOpoqwjeiuiv(bmnoitrhpwoj4325);
        }
        
        public void OnPointerClick(PointerEventData eventData)
        {
            NBHuipqwpojeoi12?.Invoke(this);
        }
    }
}