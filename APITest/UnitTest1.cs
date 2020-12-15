using APIClass;
using NUnit.Framework;

namespace APITest
{
    //this is fucking awesome
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test,Category("trial")]
        public void Test1()
        {
            GetUsers users = new GetUsers();
            users.FirstName = "suraj";
            Assert.AreEqual(users.FirstName, "suraj");
        }
        [Test, Category("APIUsers")]
        public void TestAPIUsers()
        {
            var users = new GetUsers();
            var response = users.GetUsersList();
            Assert.AreEqual(2, response.Page);


        }
    }
}