using System.Web;
using developwithpassion.bdd;
using developwithpassion.bdd.contexts;
using developwithpassion.bdd.mbunit.standard.observations;
using developwithpassion.bdddoc.core;
using nothinbutdotnetstore.web.core;
using Rhino.Mocks;

namespace nothinbutdotnetstore.tests.web
{
    public class RequestHandlerSpecs
    {
        public abstract class concern :
            observations_for_a_sut_with_a_contract<IHttpHandler,
                RequestHandler> {}

        [Concern(typeof (RequestHandler))]
        public class when_processing_an_incoming_http_context : concern
        {
            context c = () =>
            {
                front_controller = the_dependency<FrontController>();
                request_factory = the_dependency<RequestFactory>();
                http_context = null;
                request = an<FrontControllerRequest>();

                request_factory.Stub(x => x.create_from(http_context)).Return(
                    request);

            };

            because b = () =>
            {
                sut.ProcessRequest(http_context);
            };


            it should_dispatch_a_request_to_the_front_controller = () =>
            {
                front_controller.received(x => x.handle(request));
            };

            static FrontController front_controller;
            static FrontControllerRequest request;
            static HttpContext http_context;
            static RequestFactory request_factory;
        }
    }
}