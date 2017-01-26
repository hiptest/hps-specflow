namespace Hiptest.Publisher.Samples {
    using System;
    using TechTalk.SpecFlow;

    [Binding]
    public class StepDefinitions {

        public Actionwords Actionwords = new Actionwords();

        [Given("^I start the coffee machine using language \"(.*)\"$"), When("^I start the coffee machine using language \"(.*)\"$"), Then("^I start the coffee machine using language \"(.*)\"$")]
        public void IStartTheCoffeeMachineUsingLanguageLang(string lang) {
            Actionwords.IStartTheCoffeeMachineUsingLanguageLang(lang);
        }


        [Given("^I shutdown the coffee machine$"), When("^I shutdown the coffee machine$"), Then("^I shutdown the coffee machine$")]
        public void IShutdownTheCoffeeMachine() {
            Actionwords.IShutdownTheCoffeeMachine();
        }


        [Given("^message \"(.*)\" should be displayed$"), When("^message \"(.*)\" should be displayed$"), Then("^message \"(.*)\" should be displayed$")]
        public void MessageMessageShouldBeDisplayed(string message) {
            Actionwords.MessageMessageShouldBeDisplayed(message);
        }


        [Given("^coffee should be served$"), When("^coffee should be served$"), Then("^coffee should be served$")]
        public void CoffeeShouldBeServed() {
            Actionwords.CoffeeShouldBeServed();
        }


        [Given("^coffee should not be served$"), When("^coffee should not be served$"), Then("^coffee should not be served$")]
        public void CoffeeShouldNotBeServed() {
            Actionwords.CoffeeShouldNotBeServed();
        }


        [Given("^I take a coffee$"), When("^I take a coffee$"), Then("^I take a coffee$")]
        public void ITakeACoffee() {
            Actionwords.ITakeACoffee();
        }


        [Given("^I empty the coffee grounds$"), When("^I empty the coffee grounds$"), Then("^I empty the coffee grounds$")]
        public void IEmptyTheCoffeeGrounds() {
            Actionwords.IEmptyTheCoffeeGrounds();
        }


        [Given("^I fill the beans tank$"), When("^I fill the beans tank$"), Then("^I fill the beans tank$")]
        public void IFillTheBeansTank() {
            Actionwords.IFillTheBeansTank();
        }


        [Given("^I fill the water tank$"), When("^I fill the water tank$"), Then("^I fill the water tank$")]
        public void IFillTheWaterTank() {
            Actionwords.IFillTheWaterTank();
        }


        [Given("^I take \"(.*)\" coffees$"), When("^I take \"(.*)\" coffees$"), Then("^I take \"(.*)\" coffees$")]
        public void ITakeCoffeeNumberCoffees(int coffeeNumber) {
            Actionwords.ITakeCoffeeNumberCoffees(coffeeNumber);
        }


        [Given("^the coffee machine is started$"), When("^the coffee machine is started$"), Then("^the coffee machine is started$")]
        public void TheCoffeeMachineIsStarted() {
            Actionwords.TheCoffeeMachineIsStarted();
        }


        [Given("^I handle everything except the water tank$"), When("^I handle everything except the water tank$"), Then("^I handle everything except the water tank$")]
        public void IHandleEverythingExceptTheWaterTank() {
            Actionwords.IHandleEverythingExceptTheWaterTank();
        }


        [Given("^I handle water tank$"), When("^I handle water tank$"), Then("^I handle water tank$")]
        public void IHandleWaterTank() {
            Actionwords.IHandleWaterTank();
        }


        [Given("^I handle beans$"), When("^I handle beans$"), Then("^I handle beans$")]
        public void IHandleBeans() {
            Actionwords.IHandleBeans();
        }


        [Given("^I handle coffee grounds$"), When("^I handle coffee grounds$"), Then("^I handle coffee grounds$")]
        public void IHandleCoffeeGrounds() {
            Actionwords.IHandleCoffeeGrounds();
        }


        [Given("^I handle everything except the beans$"), When("^I handle everything except the beans$"), Then("^I handle everything except the beans$")]
        public void IHandleEverythingExceptTheBeans() {
            Actionwords.IHandleEverythingExceptTheBeans();
        }


        [Given("^I handle everything except the grounds$"), When("^I handle everything except the grounds$"), Then("^I handle everything except the grounds$")]
        public void IHandleEverythingExceptTheGrounds() {
            Actionwords.IHandleEverythingExceptTheGrounds();
        }


        [Given("^displayed message is:$"), When("^displayed message is:$"), Then("^displayed message is:$")]
        public void DisplayedMessageIs(string freeText) {
            Actionwords.DisplayedMessageIs(freeText);
        }


        [Given("^I switch to settings mode$"), When("^I switch to settings mode$"), Then("^I switch to settings mode$")]
        public void ISwitchToSettingsMode() {
            Actionwords.ISwitchToSettingsMode();
        }


        [Given("^settings should be:$"), When("^settings should be:$"), Then("^settings should be:$")]
        public void SettingsShouldBe(Table datatable) {
            Actionwords.SettingsShouldBe(datatable);
        }
    }
}