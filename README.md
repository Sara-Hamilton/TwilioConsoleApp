# TwilioConsoleApp

##### An app that sends texts using Twilio, Visual Studio MVC, C#, and .NET.  05/06/18

## By Sara Hamilton

# Description
This is an Epicodus practice project for week 4 of the .NET course.  Its purpose is to display understanding of using Twilio requests to send SMS text messages using Visual Studio and MVC.  


## Technologies Used
* HTML
* CSS
* Bootstrap
* Visual Studio
* C#
* .NET
* Twilio

## Set up a Twilio account
Make a free Twilio account. After you create your account, you will be asked to provide a phone number for verification. If you only want to use the free trial Twilio account, you will only be able to send texts to verified phone numbers. The number you provide here will be verified so you can use it in this app.

After you verify your account, you will be taken to your account dashboard. Click "Get Started". You will be taken to https://www.twilio.com/console/sms/getting-started/basics and given the option to get your first Twilio Phone Number. Choose one that you like, and this will be the "From" number used in this app.

Now, navigate to your Account Settings page, and find the API Credentials section containing both live and test credentials. We'll use the live Account SID and Auth Token in this app. 

Open the app solution in Visual Studio.  In the project, create a class named EnvironmentVariables.cs  Add the following code to EnvironmentVariables.cs  Replace the text that is in all caps with the account SID and authtoken from your Twilio account.  

```
namespace Texter.Models
{
    public static class EnvironmentVariables
    {
        public static string AccountSid = "YOUR ACCOUNT SID HERE";
        public static string AuthToken = "YOUR AUTHTOKEN HERE";
    }
}
```

## Run the Application  

  * _Clone the github respository_
  ```
  $ git clone https://github.com/Sara-Hamilton/TwilioConsoleApp
  ```
* _Move into the directory_
```
$ cd Texter
```
*  _Restore the program_

 ```
 $ dotnet restore
 ```
Open the program in Visual Studio and run the program.

### License

*MIT License*

Copyright (c) 2018 **_Sara Hamilton_**

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
