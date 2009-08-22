using System.IO;
using System.Text;
using developwithpassion.bdd.contexts;
using developwithpassion.bdd.mbunit;
using developwithpassion.bdd.mbunit.standard.observations;
using developwithpassion.bdddoc.core;
using developwithpassion.commons.core.infrastructure.logging;
using nothinbutdotnetstore.infrastructure.logging.basic;

namespace nothinbutdotnetstore.tests.infrastructure
{
    public class TextWriterLoggerSpecs
    {
        public abstract class concern : observations_for_a_sut_with_a_contract<Logger,
                                            TextWriterLogger> {}

        [Concern(typeof (TextWriterLogger))]
        public class when_logging_messages : concern
        {
            context c = () =>
            {
                builder = new StringBuilder();
                provide_a_basic_sut_constructor_argument<TextWriter>(new StringWriter(builder));
            };

            because b = () =>
            {
                sut.informational("hello world");
            };


            it should_log_the_message_to_its_text_writer = () =>
            {
                builder.ToString().should_be_equal_ignoring_case("hello world\r\n");
            };

            static StringBuilder builder;
        }
    }
}