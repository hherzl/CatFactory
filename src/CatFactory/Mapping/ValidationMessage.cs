using System;

namespace CatFactory.Mapping
{
    public class ValidationMessage
    {
        public ValidationMessage()
        {
        }

        public ValidationMessage(MessageType messageType, String message)
        {
            MessageType = messageType;
            Message = message;
        }

        public MessageType MessageType { get; set; }

        public String Message { get; set; }
    }
}
