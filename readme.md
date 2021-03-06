Tech Test: Gift Aid Calculator
==============================

Technical test creating a command line application for gift aid calculations in C#  

Gift Aid Amount calculated as:  

=>  donation_amount * ( tax_rate / (100 - tax_rate ) )

Technologies:
-------------
- Mono JIT compiler version 3.8.0
- NUnit 2.6.3

Objectives:
-----------
- Create a simple gift aid calculator
- Allow an admin user to update the tax rate
- Ensure rounding to two decimal places
- Allow gift aid to be supplemented based on event type

Classes:
--------
- GiftAidCalculator: calculates gift aid from inputs
- User: cannot alter the tax rate
- Admin: can alter the tax rate
- Event: can supplement gift aid based on type

Running the test suite:
-----------------------
From root:
```shell
$ mcs GiftAidCalculator.Tests/*.cs GiftAidCalculator.TestConsole/*.cs -reference:nunit.framework.dll
$ NUNIT-CONSOLE GiftAidCalculator.Tests/*.exe
```

Output:
```shell
NUnit version 2.4.8
Copyright (C) 2002-2007 Charlie Poole.
Copyright (C) 2002-2004 James W. Newkirk, Michael C. Two, Alexei A. Vorontsov.
Copyright (C) 2000-2002 Philip Craig.
All Rights Reserved.

Runtime Environment - 
   OS Version: Unix 13.3.0.0
  CLR Version: 2.0.50727.1433 ( 3.8.0 ((no/62a857e Wed Aug 13 00:46:20 EDT 2014) )

..............
Tests run: 14, Failures: 0, Not run: 0, Time: 0.034 seconds
```

Running the application:
------------------------
From root:
```shell
$ mcs GiftAidCalculator.TestConsole/*.cs  
$ mono GiftAidCalculator.TestConsole/Calculator.exe 
```

Output:
```shell
----Gift Aid Calculator 1.0----

Please enter an option:
(1) Calculate Gift Aid
(2) Update Tax Rate
(9) Exit
```


