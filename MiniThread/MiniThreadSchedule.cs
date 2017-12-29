using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MiniThread
{
    public class MiniThreadSchedule : IDisposable
    {
        public void Start(String GroupId, Func<Context, IEnumerator> funcObj)
        {

        }

        /// <summary>
        /// 释放资源
        /// </summary>
        public void Dispose()
        {

        }
    }

    public class ThreadInfo
    {
        public Func<Context, IEnumerator> FuncObj { get; set; }

        public IEnumerator Current { get; set; }

        public ThreadInfo WaitingThread { get; set; }
    }
}
