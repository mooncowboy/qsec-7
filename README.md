# How to contribute to this project

- Fork this repository
- Check open issues
- Create a feature branch with the ticket # of the bug you're working on 
- Please update the ticket to let others know you're working on it. 
- Before opening a pull request - please make sure you've merged the latest changes from upstream
- If there's no tickets or open requests - please read the overall statements and open a new ticket you can work with

# Test environment
 - https://hsf-qsec-test.azurewebsites.net
# Production Environment 
 - https://hsf-qsec.azurewebsites.net
 
# Build 
 - https://dev.azure.com/hsfdev/QSec-7/_build?definitionId=22
# Release 
 - 
 
![image](https://dev.azure.com/hsfDev/QSec-7/_apis/build/repos/{repoType}/badge?api-version=4.1-preview.1)


# The project mission 

We are on an overall mission - if you see missing tickets - feel free to open a new ticket and submit it based on our overall mission statement. 

## Mission Statement

Provide a re-usable open source version of a text service, meant to be used in an internal Micro Services Architecture.

## Requirements

### Generic requirements

* Service should designed according to RESTful principles
* Easy to get up an running on developer machine and in the cloud
* Service should able to handle multiple requests at the same time

### Version 1.0 - The Basics

Provide basic service with the following features

* Character Count - Counts the characters in a provided string
* Word Count - Counts the number of words in a string

### Version 1.1 - The Basics, Update 1

Introduce additional features:

* Find Count - Counts the number of time that one string can be found in another
* Replace - Replaces occurances of one string in another

### Version 2.0 - Complexity

Introduce the ability to return a random "quote of the day", where the available quotes should be stored and retrieved from a text file.

### Version 2.1 - Complexity, Update 1

Introduce the ability to push new quotes.

### Version 2.2 - Complexity, Update 2

Introduce the ability to clean available list of quotes in the file.

### Version 3.0
Service should handle scale out scenarios, i.e. working correctly with above requirements even if server runs on many processes and/or many machines
