using System.Collections.Generic;

namespace Hiptest.Publisher.Samples {
    using NUnit.Framework;
    using TechTalk.SpecFlow;
    using System.Linq;

    public class Actionwords {
        CoffeeMachine Sut = new CoffeeMachine();
        List<string> Handled = new List<string>();

        public void IStartTheCoffeeMachineUsingLanguageLang(string lang = "en") {
            Sut.Start(lang);
        }

        public void IShutdownTheCoffeeMachine() {
            Sut.Stop();
        }

        public void MessageMessageShouldBeDisplayed(string message = "") {
            Assert.AreEqual(message, Sut.Message);
        }

        public void CoffeeShouldBeServed() {
            Assert.IsTrue(Sut.CoffeeServed);
        }

        public void CoffeeShouldNotBeServed() {
            Assert.IsFalse(Sut.CoffeeServed);
        }

        public void ITakeACoffee() {
            Sut.TakeCoffee();
        }

        public void IEmptyTheCoffeeGrounds() {
            Sut.EmptyGrounds();
        }

        public void IFillTheBeansTank() {
            Sut.FillBeans();
        }

        public void IFillTheWaterTank() {
            Sut.FillTank();
        }

        public void ITakeCoffeeNumberCoffees(int coffeeNumber) {
            while ((coffeeNumber > 0)) {
                ITakeACoffee();
                coffeeNumber = coffeeNumber - 1;

                if (Handled.Contains("Water")) {
                    IFillTheWaterTank();
                }

                if (Handled.Contains("Beans")) {
                    IFillTheBeansTank();
                }


                if (Handled.Contains("Grounds")) {
                    IEmptyTheCoffeeGrounds();
                }
            }
        }

        public void TheCoffeeMachineIsStarted() {
            IStartTheCoffeeMachineUsingLanguageLang();
        }

        public void IHandleWaterTank() {
            Handled.Add("Water");
        }

        public void IHandleBeans() {
            Handled.Add("Beans");
        }

        public void IHandleCoffeeGrounds() {
            Handled.Add("Grounds");
        }

        public void IHandleEverythingExceptTheWaterTank() {
            this.IHandleCoffeeGrounds();
            this.IHandleBeans();
        }

        public void IHandleEverythingExceptTheBeans() {
            this.IHandleWaterTank();
            this.IHandleCoffeeGrounds();
        }

        public void IHandleEverythingExceptTheGrounds() {
            this.IHandleWaterTank();
            this.IHandleBeans();
        }

        public void DisplayedMessageIs(string freeText) {
            MessageMessageShouldBeDisplayed(freeText);
        }

        public void ISwitchToSettingsMode() {
            this.Sut.ShowSettings();
        }

        public string convertDict(Dictionary<string, string> dict) {
            return string.Join(";", dict.Select(x => x.Key + "=" + x.Value).ToArray());
        }

        public void SettingsShouldBe(Table datatable) {
            var settings = new Dictionary<string, string> {};
            var headers = datatable.Header.ToList();

            settings.Add(headers[0], headers[1]);
            foreach(var row in datatable.Rows) {
                settings.Add(row[0], row[1]);
            }

            Assert.AreEqual(this.convertDict(settings), this.convertDict(Sut.GetSettings()));
        }
    }
}