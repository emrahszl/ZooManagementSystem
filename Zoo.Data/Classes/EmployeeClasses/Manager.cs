using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Data.AbstractClasses;
using Zoo.Data.Interfaces;

namespace Zoo.Data.Classes.EmployeeClasses
{
    public class Manager : Employee, IWhiteCollar
    {
        private static int _id = 100;

        public Manager()
        {
            Id = _id;
            _id++;
        }

        public override int Id { get; }

        public void AttendMeetings()
        {
            Console.WriteLine($"{GetType()} toplantıya katıldı.");
        }

        public override void Work()
        {
            Console.WriteLine($"{GetType()} ofiste çalışıyor.");
        }

        public void ScheduleMeeting(string meetingName, DateTime meetingTime)
        {
            Console.WriteLine($"{meetingTime} tarihine {meetingName} adında bir toplantı düzenlendi.");
        }
    }
}
