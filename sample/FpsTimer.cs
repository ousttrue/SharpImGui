using System;
using System.Diagnostics;
using System.Threading;

namespace sample
{
    class FpsTimer
    {
        TimeSpan m_frameTime;
        Stopwatch m_sw;

        int m_sleep;

        public FpsTimer(int fps)
        {
            m_frameTime = TimeSpan.FromMilliseconds(1000.0 / fps);
            m_sw = Stopwatch.StartNew();
            m_sleep = (int)m_frameTime.TotalMilliseconds;
        }


        TimeSpan m_begin;
        // public void BeginFrame()
        // {
        //     m_begin = m_sw.Elapsed;
        // }

        public void Wait()
        {
            var now = m_sw.Elapsed;
            var delta = now - m_begin;
            m_begin = now;

            if (delta > m_frameTime)
            {
                m_sleep--;
                if (m_sleep < 1)
                {
                    m_sleep = 1;
                }
            }
            else
            {
                m_sleep++;
                if (m_sleep > m_frameTime.TotalMilliseconds)
                {
                    m_sleep = (int)m_frameTime.TotalMilliseconds;
                }
            }

            Thread.Sleep(m_sleep);
        }
    }
}
