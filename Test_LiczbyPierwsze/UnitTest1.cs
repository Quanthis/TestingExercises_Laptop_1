using System;
using Xunit;
using CzynnikiPierwsze;

namespace Test_LiczbyPierwsze
{
    public class UnitTest1
    {
        [Fact]
        public void Test_ZnajdzLiczbePierwsza1()
        {
            int a = 100;
            var test1 = new LiczbyPierwsze();
            int wynik=test1.ZnajdzLiczbePierwsza(a);
            int oczekiwane = 0;
            Assert.Equal(wynik, oczekiwane);
        }
        [Fact]
        public void Test_ZnajdzLiczbePierwsza2()
        {
            int a = 17;
            int oczekiwane = 17;
            var test2 = new LiczbyPierwsze();
            int wynik = test2.ZnajdzLiczbePierwsza(a);
            Assert.Equal(wynik, oczekiwane);
        }
    }
}
