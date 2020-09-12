using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Ping_study
{
    public static class LanStatusCheck
    {
        public static bool IsEffectiveness(string address)
        {
            Ping sender = new Ping();
            for (int i = 0; i < 4; i++)
            {
                PingReply reply = sender.Send(address,2000);
                if (reply.Status == IPStatus.Success)
                {
                    return true;
                    //Console.WriteLine("Reply from {0}: bytes={1} time={2}ms TTL={3}",
                    //    reply.Address,
                    //    reply.Buffer.Length,
                    //    reply.RoundtripTime,
                    //    reply.Options.Ttl);
                }
                else
                {
                    //Console.WriteLine(reply.Status);
                }
                // ping送信の間隔を取る
                if (i < 3)
                {
                    System.Threading.Thread.Sleep(1000);
                }
            }
            return false;
        }
    }
}
