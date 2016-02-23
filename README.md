# hps-specflow

[![Build Status](https://travis-ci.org/hiptest/hps-specflow.svg?branch=master)](https://travis-ci.org/hiptest/hps-specflow)

Hiptest publisher samples with Specflow

In this repository you'll find tests generated in Specflow format from [Hiptest](https://hiptest.net), using [Hiptest publisher](https://github.com/hiptest/hiptest-publisher).

The goals are:

 * to show how tests are exported in Specflow.
 * to check exports work out of the box (well, with implemented actionwords)

System under test
------------------

The SUT is a (not that much) simple coffee machine. You start it, you ask for a coffee and you get it, sometimes. But most of times you have to add water or beans, empty the grounds. You have an automatic expresso machine at work or at home? So you know how it goes :-)

Update tests
-------------

To update the tests:

    hiptest-publisher -c specflow.conf --only=features,step_definitions

The tests are generated in [``features/``](https://github.com/hiptest/hps-specflow/tree/master/features)

Run tests
---------


To build the project and run the tests, use the following command:

    xbuild specflow_samples.csproj /t:buildnunitfiles
    xbuild specflow_samples.csproj /t:compile
    xbuild specflow_samples.csproj /t:test

The SUT implementation can be seen in [``class/CoffeeMachine.cs``](https://github.com/hiptest/hps-specflow/blob/master/class/CoffeeMachine.cs)

The test report is generated in ```TestResult.xml```
