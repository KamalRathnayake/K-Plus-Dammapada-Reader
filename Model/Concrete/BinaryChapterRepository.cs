using DammapadaReader.Model.Abstract;
using DammapadaReader.Model.Domain;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace DammapadaReader.Model.Concrete
{
    public class BinaryChapterRepository : IRepository<Vagga>
    {
        List<Vagga> vaggas;
        public BinaryChapterRepository()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream fs = new FileStream("data.bin", FileMode.Open);
            vaggas = (List<Vagga>)formatter.Deserialize(fs);
        }
        public IQueryable<Vagga> Items
        {
            get
            {
                return vaggas.AsQueryable();
            }
        }

        public void Insert(Vagga item)
        {
            throw new InvalidOperationException();
        }

        public void Remove(Vagga item)
        {
            throw new InvalidOperationException();
        }

        public void Update(Vagga item)
        {
            throw new InvalidOperationException();
        }
    }
}
