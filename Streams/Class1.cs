using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Streams
{
    internal class Class1
    {
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

        public virtual void AccessToAddAdmin()
        {
            Console.WriteLine("Guruhga admin qo'shish uchun ruxsat berilgan");
        }

        public virtual void AccessToChangeGroupInfo()
        {
            Console.WriteLine("Guruh ma'lumotlarini o'zgartirish uchun ruxsat berilgan");
        }

        public virtual void AccessToReadMessages()
        {
            Console.WriteLine("Xabarlarni o'qish uchun ruxsat berilgan");
        }
        public virtual void AccessToRemoveMessages()
        {
            Console.WriteLine("Xabarlarni o'chirish uchun ruxsat berilgan");
        }


    }
}
