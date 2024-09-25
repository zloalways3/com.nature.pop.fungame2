using System;
using System.Collections;
using System.Collections.Generic;
using VNjanskdjq;
using UnityEngine;
using Random = UnityEngine.Random;

namespace NJKvnkjerk45
{
    public class GYUIpkqkwueyt : MonoBehaviour
    {
        [SerializeField] private RectTransform BHodqjwi123biu;
        [SerializeField] private RectTransform ghjpoqwihegyu32;
        [SerializeField] private OOIUGIYbenpqwooiguiy[] bhvjqwehui456;
        [SerializeField] private float bhjkpweoey1223;
        [SerializeField] private float bvoeirhoi234;
        [SerializeField] private int nvoierhtoi62 = 10;
        [SerializeField] private int ojoiheo8687123 = 10;
        [SerializeField] private int jvioerhori1 = 8;
        [SerializeField] private int ojviorthwfn23 = 6;
        [SerializeField] private float vnoiuerhiqjwepcuer = 30;
        [SerializeField] private float vpojqwoihenoijpqwe1 = 30;
        [SerializeField] private float nvowiewjpeo = 60;
        [SerializeField] private float oihreihwpvior = 60;
        
        private int vekropjrqopw123 = 0;
        private RectTransform[][] vopjeroijer01235;
        private OOIUGIYbenpqwooiguiy[][] smvioeriorh12oi3jpf;
        private POHIqwepIho123 smoijpoqwje1920;
        private int mioerhuiq123p;
        private bool ojeropjrp1234 = false;
        private int opjoiqwjel123 = 0;
        private (float, Action) pojppqpqpqp123;
        private int ppojqwe_wkqe123 = 0;
        private bool poihewnovir_12389 = false;
        private int psejiroqi91203 = 0;

        public event Action<int> ioqowoovnnr;
        public event Action<int> poqweoinv891k;
        public event Action<int> pojqwhnvp81;
        public event Action opjqiwenv56;
        public event Action qopjwenv9991;

        public int Vekropjrqopw123 => vekropjrqopw123;

        public void poiyquvhwNoi1(POHIqwepIho123 pohIqwepIho123, int POIubqjwe)
        {
            smoijpoqwje1920 = pohIqwepIho123;
            psejiroqi91203 = POIubqjwe;

            poqweoinv891k.Invoke(ojoiheo8687123);
        }

        private void Start()
        {
            Random.InitState(psejiroqi91203);
            
            ioqowoovnnr?.Invoke(vekropjrqopw123);
            mioerhuiq123p = jvioerhori1 * ojviorthwfn23;
            
            POjqPO134();
            
            NIOqnOIqwneoi();
        }

        public void MNoNPioqwe()
        {
            ojeropjrp1234 = true;

            var adgtre = 2 * 4 + 3;
            
            StopAllCoroutines();
            
            foreach (var ooiugiYbenpqwooiguiys in smvioeriorh12oi3jpf)
            {
                foreach (var OOInqkwe in ooiugiYbenpqwooiguiys)
                {
                    adgtre += 125;
                    OOInqkwe?.StopAllCoroutines();
                    OOInqkwe?.OnDisable();
                }
            }
        }

        public void HOINOIqwe()
        {
            StartCoroutine(vmowerpopoqwepv());

            if (pojppqpqpqp123 == default)
            {
                ojeropjrp1234 = false;
                return;
            }

            foreach (var Noieqnwo in smvioeriorh12oi3jpf)
            {
                foreach (var NOIqwneov in Noieqnwo)
                {
                    NOIqwneov?.BGHopqwhiegyu();
                }
            }

            StartCoroutine(BHjkMNHjoqwle(pojppqpqpqp123.Item1, pojppqpqpqp123.Item2));
        }

        private void POjqPO134()
        {
            vopjeroijer01235 = new RectTransform[jvioerhori1][];
            smvioeriorh12oi3jpf = new OOIUGIYbenpqwooiguiy[jvioerhori1][];
            
            for (int i = 0; i < jvioerhori1; ++i)
            {
                vopjeroijer01235[i] = new RectTransform[ojviorthwfn23];
                smvioeriorh12oi3jpf[i] = new OOIUGIYbenpqwooiguiy[ojviorthwfn23];

                var a = "we123";
                
                for (int j = 0; j < ojviorthwfn23; ++j)
                {
                    a += "wqe";
                    var cell = Instantiate(ghjpoqwihegyu32, BHodqjwi123biu);
                    cell.anchoredPosition = new Vector3(
                        vpojqwoihenoijpqwe1 + oihreihwpvior * j,
                        -vnoiuerhiqjwepcuer - nvowiewjpeo * i,
                        0
                    );

                    vopjeroijer01235[i][j] = cell;
                }
            }
        }
        
        private void NIOqnOIqwneoi()
        {
            for (int i = 0; i < jvioerhori1; ++i)
            {
                for (int j = 0; j < ojviorthwfn23; ++j)
                {
                    if (smvioeriorh12oi3jpf[i][j] != null)
                        continue;
                    
                    var NOInqwoeiv = Instantiate(
                        bhvjqwehui456[Random.Range(0, bhvjqwehui456.Length)], 
                        vopjeroijer01235[i][j].transform
                    );
                    smvioeriorh12oi3jpf[i][j] = NOInqwoeiv;

                    NOInqwoeiv.NBHuipqwpojeoi12 += PInOIonqoiNioqwe;
                }
            }
        }

        private void NOiNioqwenOIqw(OOIUGIYbenpqwooiguiy ooiugiYbenpqwooiguiy)
        {
            ojeropjrp1234 = true;
            
            (int, int) IoqnwePOI = NioqnwIOnoeqw(ooiugiYbenpqwooiguiy);
            
            OIuJKhubeqoIoqwe(IoqnwePOI.Item1, IoqnwePOI.Item2);
        }

        private void MOiNIOqnOIq((int, int) MIoNoiqwe, (int, int) PoijHYTgq)
        {
            var POqPOqJPOqe = smvioeriorh12oi3jpf[MIoNoiqwe.Item1][MIoNoiqwe.Item2];
            var Nifnreuin1o23 = smvioeriorh12oi3jpf[PoijHYTgq.Item1][PoijHYTgq.Item2];
            
            (smvioeriorh12oi3jpf[MIoNoiqwe.Item1][MIoNoiqwe.Item2], smvioeriorh12oi3jpf[PoijHYTgq.Item1][PoijHYTgq.Item2]) = 
                (Nifnreuin1o23, POqPOqJPOqe);

            if (POqPOqJPOqe != null)
            {
                POqPOqJPOqe.transform.SetParent(vopjeroijer01235[PoijHYTgq.Item1][PoijHYTgq.Item2]);
                POqPOqJPOqe.HgpowqwpejOIje(bvoeirhoi234);
            }

            if (Nifnreuin1o23 != null)
            {
                Nifnreuin1o23.transform.SetParent(vopjeroijer01235[MIoNoiqwe.Item1][MIoNoiqwe.Item2]);
                Nifnreuin1o23.HgpowqwpejOIje(bvoeirhoi234);
            }
        }

        private void OIuJKhubeqoIoqwe(int x, int y)
        {
            var OPJqoJPoqwjep213 = POjOIjoiOIqoiwe(x, y);

            if (OPJqoJPoqwjep213.Count > 0)
            {
                opjoiqwjel123 += 1;
                pojqwhnvp81?.Invoke(opjoiqwjel123);
                
                NIOcneiownoInoi123(OPJqoJPoqwjep213);
            }
            else
            {
                ojeropjrp1234 = false;
            }
        }

        private HashSet<(int, int)> POjOIjoiOIqoiwe(int x, int y)
        {
            HashSet<(int, int)> POjqwpoeJPo123 = new HashSet<(int, int)>();
            Queue<(int, int)> NIOncoiqwneoi1245 = new Queue<(int, int)>();
            NIOncoiqwneoi1245.Enqueue((x, y));

            while (NIOncoiqwneoi1245.Count > 0)
            {
                var (i, j) = NIOncoiqwneoi1245.Dequeue();

                if (!POjqwpoeJPo123.Contains((i - 1, j)) && PoqPOmvvIOq(i, j, i - 1, j))
                {
                    POjqwpoeJPo123.Add((i, j));
                    POjqwpoeJPo123.Add((i - 1, j));
                    NIOncoiqwneoi1245.Enqueue((i - 1, j));
                }
                if (!POjqwpoeJPo123.Contains((i + 1, j)) && PoqPOmvvIOq(i, j, i + 1, j))
                {
                    POjqwpoeJPo123.Add((i, j));
                    POjqwpoeJPo123.Add((i + 1, j));
                    NIOncoiqwneoi1245.Enqueue((i + 1, j));
                }
                if (!POjqwpoeJPo123.Contains((i, j - 1)) && PoqPOmvvIOq(i, j, i, j - 1))
                {
                    POjqwpoeJPo123.Add((i, j));
                    POjqwpoeJPo123.Add((i, j - 1));
                    NIOncoiqwneoi1245.Enqueue((i, j - 1));
                }
                if (!POjqwpoeJPo123.Contains((i, j + 1)) && PoqPOmvvIOq(i, j, i, j + 1))
                {
                    POjqwpoeJPo123.Add((i, j));
                    POjqwpoeJPo123.Add((i, j + 1));
                    NIOncoiqwneoi1245.Enqueue((i, j + 1));
                }
            }

            return POjqwpoeJPo123;
        }

        private void MIOnIOneqwioNoirni3o2()
        {
            for (int i = 0; i < jvioerhori1; ++i)
            {
                for (int j = 0; j < ojviorthwfn23; ++j)
                {
                    if (
                        PoqPOmvvIOq(i, j, i + 1, j) ||
                        PoqPOmvvIOq(i, j, i, j + 1)
                    )
                    {
                        ojeropjrp1234 = false;

                        return;
                    }
                }
            }
            
            MNoNPioqwe();
            ojeropjrp1234 = poihewnovir_12389 = true;
            smoijpoqwje1920.PoqjwePO12();
            opjqiwenv56?.Invoke();
        }

        private void NIOcneiownoInoi123(HashSet<(int, int)> voperOIe1)
        {
            foreach (var vmoroinro in voperOIe1)
            {
                var pqwoejv = smvioeriorh12oi3jpf[vmoroinro.Item1][vmoroinro.Item2];
                smvioeriorh12oi3jpf[vmoroinro.Item1][vmoroinro.Item2] = null;
                
                pqwoejv.NBHuipqwpojeoi12 -= PInOIonqoiNioqwe;

                mioerhuiq123p -= 1;
                POinquIBoewi(pqwoejv);
                pqwoejv.NBIOpoqwjeiuiv(bhjkpweoey1223);
            }

            if (voperOIe1.Count > 0)
                smoijpoqwje1920.HjkNBGYujGyu();
                
            StartCoroutine(BHjkMNHjoqwle(bhjkpweoey1223, BHjoIUgyqhweoNPOIu));
        }

        private bool PoqPOmvvIOq(int i1, int j1, int i2, int j2) =>
            i1 >= 0 && i1 < jvioerhori1 && j1 >= 0 && j1 < ojviorthwfn23 &&
            i2 >= 0 && i2 < jvioerhori1 && j2 >= 0 && j2 < ojviorthwfn23 &&
            smvioeriorh12oi3jpf[i1][j1] != null && smvioeriorh12oi3jpf[i2][j2] != null && 
            smvioeriorh12oi3jpf[i1][j1].Fbyuewoqr == smvioeriorh12oi3jpf[i2][j2].Fbyuewoqr;
        
        private void POinquIBoewi(OOIUGIYbenpqwooiguiy ooiugiYbenpqwooiguiy)
        {
            vekropjrqopw123 += nvoierhtoi62;
            
            ioqowoovnnr?.Invoke(vekropjrqopw123);

            if (mioerhuiq123p == 0 && !poihewnovir_12389)
            {
                ojeropjrp1234 = poihewnovir_12389 = true;
                smoijpoqwje1920.PoqjwePO12();
                opjqiwenv56?.Invoke();
            }
        }

        private void BHjoIUgyqhweoNPOIu()
        {
            for (int i = jvioerhori1 - 1; i >= 0; --i)
            {
                for (int j = ojviorthwfn23 - 1; j >= 0; --j)
                {
                    if (smvioeriorh12oi3jpf[i][j] is null)
                    {
                        for (int k = i - 1; k >= 0; --k)
                        {
                            if (smvioeriorh12oi3jpf[k][j] is null)
                                continue;

                            MOiNIOqnOIq((i, j), (k, j));
                            break;
                        }
                    }
                }
            }

            StartCoroutine(BHjkMNHjoqwle(bvoeirhoi234, POmoiNuinqwoeiv));
        }

        private void POmoiNuinqwoeiv()
        {
            var POjpmOPInqwpe = new List<int>(ojviorthwfn23);
            
            for (int j = 0; j < ojviorthwfn23; ++j)
            {
                for (int i = jvioerhori1 - 1; i >= 0; --i)
                {
                    if (smvioeriorh12oi3jpf[i][j] != null)
                        break;

                    if (i == 0)
                    {
                        POjpmOPInqwpe.Add(j);
                    }
                }
            }

            foreach (var col in POjpmOPInqwpe)
            {
                for (int j = col - 1; j >= 0; --j)
                {
                    for (int i = jvioerhori1 - 1; i >= 0; --i)
                    {
                        if (smvioeriorh12oi3jpf[i][j] is null)
                            break;
                        
                        MOiNIOqnOIq((i, j), (i, j + 1));
                    }
                }
            }
                
            StartCoroutine(BHjkMNHjoqwle(bvoeirhoi234, MIOnIOneqwioNoirni3o2));
        }

        private void PInOIonqoiNioqwe(OOIUGIYbenpqwooiguiy ooiugiYbenpqwooiguiy)
        {
            if (ojeropjrp1234)
                return;
            
            NOiNioqwenOIqw(ooiugiYbenpqwooiguiy);
        }

        private (int, int) NioqnwIOnoeqw(OOIUGIYbenpqwooiguiy ooiugiYbenpqwooiguiy)
        {
            for (int i = 0; i < jvioerhori1; ++i)
            {
                for (int j = 0; j < ojviorthwfn23; ++j)
                {
                    if (smvioeriorh12oi3jpf[i][j] == ooiugiYbenpqwooiguiy)
                        return (i, j);
                }
            }

            return (-1, -1);
        }

        private IEnumerator BHjkMNHjoqwle(float vpoejroiqrp, Action bniqnioqwep)
        {
            pojppqpqpqp123 = (vpoejroiqrp, bniqnioqwep);
            
            yield return new WaitForSeconds(vpoejroiqrp);

            pojppqpqpqp123 = default;
            bniqnioqwep.Invoke();
        }

        private IEnumerator vmowerpopoqwepv()
        {
            while (true)
            {
                ppojqwe_wkqe123 += 1;
                
                poqweoinv891k.Invoke(ojoiheo8687123 - ppojqwe_wkqe123);

                if (ppojqwe_wkqe123 >= ojoiheo8687123)
                {
                    ojeropjrp1234 = true;
                    qopjwenv9991.Invoke();
                    smoijpoqwje1920.PinqwPonpeqw();
                    break;
                }

                yield return new WaitForSeconds(1);
            }
        }
    }
}