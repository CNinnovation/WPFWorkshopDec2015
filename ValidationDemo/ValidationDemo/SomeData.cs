using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationDemo
{
    public class SomeData : IDataErrorInfo
    {
        private int _val1;

        string IDataErrorInfo.this[string columnName]
        {
            get
            {
                string retError = null;
                switch (columnName)
                {
                    case nameof(Val2):
                        if (Val2 > 50) retError = $"invalid value for {nameof(Val2)}";
                        break;

                    default:
                        break;
                }
                return retError;
            }
        }

        string IDataErrorInfo.Error
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int Val1
        {
            get { return _val1; }
            set
            {
                if (value > 50) throw new Exception("bad value!!");
                _val1 = value;
            }
        }

        public int Val2 { get; set; }


    }
}
