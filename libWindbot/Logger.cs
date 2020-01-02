using Android.Util;
using System;

namespace WindBot
{
    public static class Logger
    {
        public static void WriteLine(string message)
        {
            Log.Info("Edoprowindbot", "[" + DateTime.Now.ToString("yy-MM-dd HH:mm:ss") + "] " + message);
        }
        public static void DebugWriteLine(string message)
        {
#if DEBUG
            Console.WriteLine("[" + DateTime.Now.ToString("yy-MM-dd HH:mm:ss") + "] " + message);
#endif
        }
        public static void WriteErrorLine(string message)
        {
            Log.Error("Edoprowindbot", "[" + DateTime.Now.ToString("yy-MM-dd HH:mm:ss") + "] " + message);
        }
    }
}