using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ioc_Di.Domain {
    public static class MessageServiceFactory {
        public static Email CreateEmail() {
            return new Email();
        }
        public static SMS CreateSMS() {
            return new SMS();
        }

    }
}

