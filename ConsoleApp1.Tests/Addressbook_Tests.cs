

using ConsoleApp1.Models;
using ConsoleApp1.Services;

namespace ConsoleApp1.Tests
{
    [TestClass]
    public class Addressbook_Tests
    {
        [TestMethod]
        public void Should_Add_Contact_To_List()
        {
            //arrange
            Addressbook addressbook = new Addressbook();
            Contact contact = new Contact();
            


            //act

            addressbook.ContactList.Add(contact);

            //assert
            Assert.AreEqual(1, addressbook.ContactList.Count);
        }
    }
}
