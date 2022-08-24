namespace MemberFinalizersDestructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Member lucy = new Member(memberName: "Lucy", jobTitle: "Developer", age: 32, salary: 2000);
            Member ali = new Member(memberName: "Ali", jobTitle: "Designer", age: 45, salary: 1570.500M); ;

            // calling methods
            lucy.Introducing(true);
            ali.Introducing(false);

        }
    }
}