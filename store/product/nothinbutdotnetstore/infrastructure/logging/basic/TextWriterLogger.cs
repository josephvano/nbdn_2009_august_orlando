using System;
using System.IO;
using developwithpassion.commons.core.infrastructure.logging;

namespace nothinbutdotnetstore.infrastructure.logging.basic
{
    public class TextWriterLogger : Logger
    {
        TextWriter text_writer;

        public TextWriterLogger(TextWriter text_writer)
        {
            this.text_writer = text_writer;
        }

        public void informational(string message)
        {
            text_writer.WriteLine(message);
        }

        public void error(Exception exception)
        {
            throw new NotImplementedException();
        }
    }
}