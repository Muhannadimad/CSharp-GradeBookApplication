using GradeBook.Enums;
namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {

        public StandardGradeBook(string name, bool x) : base(name, x)
        {
            Name = name;
            Type = GradeBookType.Standard;
        }
    }
}