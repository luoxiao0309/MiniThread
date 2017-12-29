using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniThread
{
    public class Context
    {
        public String GroupId { get; set; }

        public void SetData(Object key, Object val)
        {
            throw new NotImplementedException();
        }

        public Object GetData(Object key)
        {
            throw new NotImplementedException();
        }

        internal void AttachWaitObject()
        {

        }
    }
}
