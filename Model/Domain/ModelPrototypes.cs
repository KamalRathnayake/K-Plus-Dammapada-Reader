using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DammapadaReader.Model.Domain
{

    [Serializable]
    public class Vagga
    {
        public string Name { get; set; }
        public List<Stanza> Stanzas { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
    [Serializable]
    public class Stanza
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public string HTML { get; set; }
        public override string ToString()
        {
            return Name+" Vaththu";
        }
    }

}
