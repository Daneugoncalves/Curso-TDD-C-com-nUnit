using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asserts
{
   public class DatasEspeciaisStore
    {
        public DateTime Data(DatasEspeciais datasEspeciais)
        {
            switch (datasEspeciais)
            {
                case DatasEspeciais.AnoNovo:
                    return new DateTime(2017, 1, 1, 0, 0, 0, 0);
                case DatasEspeciais.MeuAniversario:
                    return new DateTime(2021, 12, 1, 0, 0, 0, 0);
                default:
                    throw new ArgumentOutOfRangeException("datasEspeciais");
            }
        }
    }
}
