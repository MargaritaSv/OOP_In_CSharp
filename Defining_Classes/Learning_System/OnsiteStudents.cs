
namespace Learning_System
{

    class OnsiteStudents : CurrentStudents
    {

        private string visited;

        public OnsiteStudents(string fName, string secName, int age, int number, double avg, string visited)
           : base(fName, secName, age, number, avg,visited)
        {
            this.visited = visited;
        }

        public string Vidsited
        {
            get { return this.visited; }
            set { this.visited = value; }
        }
    }
}
