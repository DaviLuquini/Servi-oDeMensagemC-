using Amazon;
using System;
using System.Collections.Generic;
using Amazon.SimpleEmail;
using Amazon.SimpleEmail.Model;
using Amazon.Runtime;

//TODO FAZER ENVIO DE EMAIL VIA SES DA AMAZON 
public class Email : IMessageService {

    static readonly string senderAddress = "davi.luquini@innovt.com.br";



    static readonly string receiverAddress = "davi262016@gmail.com";


    //static readonly string configSet = "ConfigSet";


    static string subject = "Amazon SES test (AWS SDK for .NET)";


    static string textBody = "AWS SES Test";

    static readonly string htmlBodyTemplate = @"<html>
<head></head>
<body>
  <h1>{0}</h1>
  <p>This email was sent with
    <a href='https://aws.amazon.com/ses/'>Amazon SES</a> using the
    <a href='https://aws.amazon.com/sdk-for-net/'>
      AWS SDK for .NET</a>.</p>
<p>Client Message: {1}</p>
</body>
</html>";

    public async Task SendMessage(string ClientMessage) {
        try {
            Console.WriteLine("Write the Title of your Email:");
            String ClientTitle = Console.ReadLine();
            subject = ClientTitle;
            var credentials = new BasicAWSCredentials("AKIAQ6QBXUVPAWMCIOZG", "DG1xgjH9lx9nR5QvnsDoD8ka66mbZvLUcM+m9Zyq");

            using (var client = new AmazonSimpleEmailServiceClient(credentials, RegionEndpoint.SAEast1)) {
                var htmlBody = string.Format(htmlBodyTemplate, ClientTitle, ClientMessage);

                var sendRequest = new SendEmailRequest {
                    Source = senderAddress,
                    Destination = new Destination {
                        ToAddresses =
                        new List<string> { receiverAddress }
                    },
                    Message = new Message {
                        Subject = new Content(subject),
                        Body = new Body {
                            Html = new Content {
                                Charset = "UTF-8",
                                Data = htmlBody
                            },
                            Text = new Content {
                                Charset = "UTF-8",
                                Data = textBody
                            }
                        }
                    },

                    //ConfigurationSetName = configSet

                };

                //Console.WriteLine("TextBody content: " + textBody); 


                Console.WriteLine("Sending email using Amazon SES...");
                var response = await client.SendEmailAsync(sendRequest);
                Console.WriteLine("The email was sent successfully to: " + receiverAddress);
            }
        }
        catch (Exception ex) {
            Console.WriteLine("The email was not sent.");
            Console.WriteLine("Error message: " + ex.Message);

            throw;
        }


        Console.WriteLine("Email sent: " + ClientMessage);
    }
}




/* {
"Version": "2012-10-17",
    "Statement": [
        {
                "Effect": "Allow",
            "Action": "ses:SendRawEmail",
            "Resource": "*"
        }
    ]
}*/