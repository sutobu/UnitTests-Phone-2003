using ClassLibrary;


namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Konstruktor_Dane_poprawne()
        {
            //AAA

            //ARRANGE
            var wlasciciel = "Molenda";
            var numerTelefonu = "123456789";

            //ACT
            var phone = new Phone(wlasciciel, numerTelefonu);

            //ASSERT
            Assert.AreEqual(wlasciciel, phone.Owner);
            Assert.AreEqual(numerTelefonu, phone.PhoneNumber);

        }
    }
}