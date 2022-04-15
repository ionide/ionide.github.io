---
title: Testing your code
menu_order: 7
---

# Testing your code

Ionide now includes a Test Explorer to make it easier to run your tests. The explorer will discover test as your code is type-checked, and allows for running all tests, or a subset of tests.  Any error results will be show at the test location, directly in your code!

Your projects will be built before running the tests to ensure the most up-to-date version is used.

The Test Explorer will detect tests for NUnit, XUnit, and Expecto currently, and requires a `dotnet test` adapter for your chosen framework be installed and configured in order to work. If you can run `dotnet test` on your tests successfully, you're all set!