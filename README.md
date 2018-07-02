# Clickatell-Csharp
This is a C# class built in VS2015 which sends out SMS's using the Clickatell Rest API

##Requirements:
This script is built with .NETFramework 4.5.2
Newtonsoft.JSON 9.0.1

##Installation:
add Rest.cs and API.cs into your project from the Scripts folder
Add the Newtonsoft.JSON package to your project or the newtonsoft.json.dll file to your project

##What This Class Can Do:

This script allows you to send an sms or a 2 way message using Clickatell's platform.

##Using The Class:

You call the class by using 
```
private string response;
private string api;
Dictionary<string, string> Params = new Dictionary<string, string>();

response = Api.SendSMS(api, Params);
```

Where api is your api key given to you on the platform and Params is a Dictionary of the parameters to send with the sms.

required parameters are:

to: the telephone number you are sending the sms to including the country code (must start with +)

content: the sms message that must be sent.

A full list of parameters can be found here:

https://www.clickatell.com/developers/api-documentation/rest-api-request-parameters


You can add the parameters to the dictionary by using the following code:
```
Params.Add("content", "this is a message");
Params.Add("to", "+27745555555");
```
To add more than one number to send to multiple recipients, you will just comma delimit the numbers:
```
Params.Add("to", "+27745555555,+27748888888,+27835555555");
```
Once the sms is sent, it will return a response in the form of a JSON array.

The Json array will include an array of messages which each in turn contains:

* An API Message ID
* Whether the message was accepted or not (true / false)
* The number it was sent to
* an error message if applicable (see link below to error messages)

## Reference Links and More Info:

Found a bug or missing a feature? Log it here and we will take a look.
https://github.com/ninjakitteh69/Clickatell-Csharp/issues

Register a new account to send sms's:
https://www.clickatell.com/sign-up/

Login to platform for API id, etc:
https://portal.clickatell.com/#/login

Request Parameters:
https://www.clickatell.com/developers/api-documentation/rest-api-request-parameters/

Send Message Info:
https://www.clickatell.com/developers/api-documentation/rest-api-send-message/

Error Messages:
https://www.clickatell.com/developers/api-documentation/rest-api-error-message-descriptions/
