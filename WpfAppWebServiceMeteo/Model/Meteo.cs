using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppWebServiceMeteo.Model
{
    public class Meteo
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string dataVal;

        public string DataVal
        {
            get { return dataVal; }
            set { dataVal = value; }
        }
        private string descVal;

        public string DescVal
        {
            get { return descVal; }
            set { descVal = value; }
        }
    }
}
