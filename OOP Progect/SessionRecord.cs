using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Progect
{
    // الكلاس الأساسي
    public class Session
    {
        public string Date { get; set; } = "";
        public string Duration { get; set; } = "";

        public virtual string GetSummary()
        {
            return Date + " - " + Duration;
        }
    }

    // الكلاس اللي بيتم استخدامه في الجدول
    public class SessionRecord : Session
    {
        public string BreakTime { get; set; } = "";
        public SessionStatus Status { get; set; }

        public override string GetSummary()
        {
            return Date + " - " + Duration + " - " + BreakTime + " - " + Status;
        }
    }

    // حالة السيشن
    public enum SessionStatus
    {
        Success,
        Failed
    }
}