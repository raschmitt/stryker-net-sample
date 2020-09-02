# Striker.Net Sample

[![Azure DevOps builds (job)](https://img.shields.io/azure-devops/build/raschmitt/7618d927-8467-43e2-b5e9-1aeddc1fbfdc/13?label=Build%20%26%20Test&style=flat-square)](https://dev.azure.com/raschmitt/raschmitt/_build?definitionId=13)
[![Sonar Coverage](https://img.shields.io/sonar/coverage/raschmitt_stryker-net-sample?label=Code%20Coverage&server=https%3A%2F%2Fsonarcloud.io&style=flat-square)](https://sonarcloud.io/dashboard?id=raschmitt_stryker-net-sample)
[![Mutation testing badge](https://img.shields.io/endpoint?style=flat-square&url=https%3A%2F%2Fbadge-api.stryker-mutator.io%2Fgithub.com%2Fraschmitt%2Fstryker-net-sample%2Fmaster)](https://dashboard.stryker-mutator.io/reports/github.com/raschmitt/stryker-net-sample/master)

This is a sample project that demonstrates how [Stryker .Net](https://github.com/stryker-mutator/stryker-net) can be used to run mutation tests in .Net Core, if you are looking for more information on Stryker itself or what mutation tests can do for you, please refer to their [official website](https://stryker-mutator.io/).

## Project Dependencies 

- [.Net Core 3.1](https://devblogs.microsoft.com/dotnet/announcing-net-core-3-1/)

## Local Run

After cloning this repository the first thing to be done is to install Stryker globally:

```
dotnet tool install -g dotnet-stryker
```

Then go to the tests folder location: 

```
cd <repository location>\Stryker.Net.Sample\Stryker.Net.Sample.Tests
```

And run the mutation tests:

```
dotnet stryker
```

After Stryker is done it will display your mutation score and the complete html report location. 

![Console reporter](https://i.imgur.com/CpCurCL.png "Console reporter")

## Continuous Integartion

- [Sample workflow](https://github.com/raschmitt/stryker-net-sample/blob/master/.github/workflows/mutation-tests.yml)

The sample workflow file shows how to easily integrate mutation tests through Stryker into a continuous integration strategy and publish results to its dashboard.

This workflow is automatically run every day, and the latest results can be found [here](https://dashboard.stryker-mutator.io/reports/github.com/raschmitt/stryker-net-sample/master).
