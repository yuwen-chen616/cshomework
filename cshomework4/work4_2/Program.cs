using System;

namespace work4_2
{
    class Program
    {
        public delegate void AlmClkHandler(object sender);

        class AlarmClock
        {
            //定义滴答（OnTick）事件和响铃（OnAlarm）事件
            public event AlmClkHandler OnTick;
            public event AlmClkHandler OnAlarm;

            public void Tick()
            {
                //触发OnTick事件
                OnTick(this);
            }

            public void Alarm()
            {
                //触发OnAlarm事件
                OnAlarm(this);
            }
        }

        class Form
        {
            public AlarmClock alarmClock1;
            public Form()
            {
                alarmClock1 = new AlarmClock();
                alarmClock1.OnTick += PrintTick;
                alarmClock1.OnAlarm += PrintAlarm;
            }

            //控制台输出滴答事件信息
            void PrintTick(object sender)
            {
                Console.WriteLine("滴答");
            }

            //控制台输出响铃事件信息
            void PrintAlarm(object sender)
            {
                Console.WriteLine("叮铃铃，叮铃铃……");
            }
        }
        static void Main(string[] args)
        {
            Form form1 = new Form();
            form1.alarmClock1.Tick();//模拟闹钟滴答
            form1.alarmClock1.Alarm();//模拟闹钟响铃
        }
    }
}
