using System;
using System.Collections.Generic;

public class NjknKJnqwke
{
        private static NjknKJnqwke nklfnweklklq;
        private readonly Dictionary<Type, object> anvnkt = new Dictionary<Type, object>();

        public static NjknKJnqwke Njkndkjqw => nklfnweklklq ??= new NjknKJnqwke();
        
        private NjknKJnqwke()
        {
        }

        public void NjnJKNkjq<IUHHiuhi>(IUHHiuhi NkaNKasd)
        {
                var Njkasndkjqnjk = typeof(IUHHiuhi);
                
                if (anvnkt.ContainsKey(Njkasndkjqnjk))
                        throw new ArgumentException($"{Njkasndkjqnjk} vmrkelq qmwe");

                anvnkt[Njkasndkjqnjk] = NkaNKasd;
        }

        public MKlKNlkq BHbkqwbekj1<MKlKNlkq>()
        {
                var ansdlkqwle = typeof(MKlKNlkq);

                if (!anvnkt.ContainsKey(ansdlkqwle))
                        throw new ArgumentException($"{ansdlkqwle} nlkwknf lwekr");

                return (MKlKNlkq) anvnkt[ansdlkqwle];
        }
}