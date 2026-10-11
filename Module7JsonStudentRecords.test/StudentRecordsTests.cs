using Module7JsonStudentRecords;
using NUnit.Framework;
namespace Module7JsonStudentRecords.Test
{
    [TestFixture]
    public class StudentRecordsTests
    {

        [Test]
        public void ThrowFileNotFoundException()
        {
            Assert.Throws<FileNotFoundException>(LoadStudents());
        }
    }
}
