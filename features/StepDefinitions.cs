namespace Hiptest.Publisher.Samples {
    using System;
    using TechTalk.SpecFlow;

    [Binding]
    public class StepDefinitions {

        public Actionwords Actionwords = new Actionwords();

        [Given("^I start the coffee machine \"(.*)\"$"), When("^I start the coffee machine \"(.*)\"$"), Then("^I start the coffee machine \"(.*)\"$")]
        public void IStartTheCoffeeMachine(string lang) {
            Actionwords.IStartTheCoffeeMachine(lang);
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


        [Given("^fifty coffees have been taken without filling the tank$"), When("^fifty coffees have been taken without filling the tank$"), Then("^fifty coffees have been taken without filling the tank$")]
        public void FiftyCoffeesHaveBeenTakenWithoutFillingTheTank() {
            Actionwords.FiftyCoffeesHaveBeenTakenWithoutFillingTheTank();
        }


        [Given("^thirty eight coffees are taken without filling beans$"), When("^thirty eight coffees are taken without filling beans$"), Then("^thirty eight coffees are taken without filling beans$")]
        public void ThirtyEightCoffeesAreTakenWithoutFillingBeans() {
            Actionwords.ThirtyEightCoffeesAreTakenWithoutFillingBeans();
        }
    }
}