using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio.TwiML.Voice;

namespace Ioc_Di.Domain {
    public static class MessageServiceFactory {
        public static IMessageService Create(String type) {
            if(type =="EMAIL") {
                return new Email();
            }

            if (type == "SMS") {
                return new SMS();
            }

            return null;

        }

    }
}

