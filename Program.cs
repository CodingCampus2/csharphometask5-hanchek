using System;
using CodingCampusCSharpHomework;

namespace HomeworkTemplate
{
    class SuperVirus : Task5.Virus {
        public SuperVirus() : base(false)
        {
            DateTimeOfCreation = DateTime.Now;
        }
        public override string Name
        {
            get => name;
            set { name = value.Replace("virus", "supervirus"); }
        }
        public override string VictimName { get; set; }
        public override float KillProbability
        {
            get { return killProbability; }
            set { killProbability = Math.Clamp(value * 2, 0f, 1f); }
        }
        public override DateTime DateTimeOfCreation { get; }

        private string name;
        private float killProbability;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Func<Task5, Task5.Virus> TaskSolver = task =>
            {
                Task5.Virus virus = new SuperVirus();
                return virus;
            };
            Task5.CheckSolver(TaskSolver);
        }
    }
}
