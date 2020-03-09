using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Test001.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string StudentId { get; set; }
        public enum PenaltyMethod
        {
            PushUp = 0,
            Cash = 1
        }
        public PenaltyMethod Method { get; set; }
        public double Monney { get; set; }
        public int PushUp { get; set; }
        public DateTime Time { get; set; }

    }
}