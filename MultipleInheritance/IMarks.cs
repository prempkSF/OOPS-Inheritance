

namespace MultipleInheritance
{
    public interface IMarks
    {
        public int Physics { get; set; }
        public int Chemistry { get; set; }
        public int Maths { get; set; }
        public void GetMarks(int physics,int chemistry,int maths);
        public string ShowMarks();
    }
}