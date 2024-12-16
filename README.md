# specflow-retry
SpecFlow generator plugin that adds ability to retry tests on failure for MSTest/[NUnit](http://nunit.org/).

## Versions
"Reqnroll.RetryCore" version="1.0.0" (dependency on "Reqnroll" version="2.2.1")

## Setup

Add the nuget package

## Usage

Adding a retry at the feature level will re-try any failing scenario:

```
@retry:1
Feature: SampleFeature
    In order to avoid silly mistakes
    As a math idiot
    I want to be told the sum of two numbers

Scenario: Tag on feature should be applied
    Then scenario should be run 2 times

Scenario Outline: Tag on feature should be applied to outlined scenario
    Then scenario "<example>" should be run 2 times
Examples: 
    | example |
    | first   |
    | second  |
```

Adding a retry at the scenario level will re-try the failing scenario:

```
@retry:2
Scenario: Random number generator test
    Given I have random number generator
    When it generates number
    Then I'll be lucky if it will be greater then 0.3
```

## Build status
