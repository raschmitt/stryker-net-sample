# Striker.Net Sample

[![GitHub Workflow Status](https://img.shields.io/github/workflow/status/raschmitt/stryker-net-sample/.NET%20Core%20-%20Build%20&%20Test?label=Build%20%26%20Test&style=flat-square)](https://github.com/raschmitt/stryker-net-sample/actions?query=workflow%3A%22.NET+Core+-+Build+%26+Test%22)
[![GitHub Workflow Status](https://img.shields.io/github/workflow/status/raschmitt/stryker-net-sample/Mutation%20Tests?label=Mutation%20tests&style=flat-square)](https://dashboard.stryker-mutator.io/reports/github.com/raschmitt/stryker-net-sample/master)
[![Mutation testing badge](https://img.shields.io/endpoint?style=flat-square&url=https%3A%2F%2Fbadge-api.stryker-mutator.io%2Fgithub.com%2Fraschmitt%2Fstryker-net-sample%2Fmaster)](https://dashboard.stryker-mutator.io/reports/github.com/raschmitt/stryker-net-sample/master)

This is a sample project that demonstrates how [Stryker .Net](https://github.com/stryker-mutator/stryker-net) can be used to run mutation tests in .Net Core, if you are looking for more information on Stryker itself or what mutaion tests can do for you please refer to their [offcial website](https://stryker-mutator.io/).

## Dependencies 

- [.Net Core 3.1](https://devblogs.microsoft.com/dotnet/announcing-net-core-3-1/)
- [FluentAssertions](https://fluentassertions.com/)

## Local Run

First of all let's install Struker globally.

`dotnet tool install -g dotnet-stryker`

After installing and properly cloning this respository, simply go to the tests folder location. 

`cd <repository location>\Stryker.Net.Sample\Stryker.Net.Sample.Tests`

And finally run the mutation tests.

`dotnet stryker`

This will run the mutations based on the configurations of the `stryker-config.json` file, present in this directory. The mutation score and the location where to find the complete html report will be displayed into the console.

![Console reporter](https://i.imgur.com/CpCurCL.png "Console reporter")


## Continuous Integartion

- [Sample workflow](https://github.com/raschmitt/stryker-net-sample/blob/master/.github/workflows/mutation-tests.yml)

The sample workflow file shows how to easily integrate mutation tests trough Stryker into a continous integration estrategy and publish results to its dashboard.

This workflow is automattically run every friday, and the results for its latest run can be found [here](https://dashboard.stryker-mutator.io/reports/github.com/raschmitt/stryker-net-sample/master).
