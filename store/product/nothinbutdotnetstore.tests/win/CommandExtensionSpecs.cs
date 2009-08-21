 using System;
 using System.Windows.Forms;
 using developwithpassion.bdd.contexts;
 using developwithpassion.bdd.mbunit.standard.observations;
 using developwithpassion.bdddoc.core;
 using MbUnit.Framework;
 using nothinbutdotnetstore.win;

namespace nothinbutdotnetstore.tests.win
 {   
     public class CommandExtensionSpecs
     {
         public abstract class concern : observations_for_a_sut_with_a_contract<Form,
                                             DriveBrowser>
         {
        
         }

         [Ignore("Only run when you want to show the ui for testing commands")]
         [Concern(typeof(DriveBrowser))]
         public class when_viewing_a_text_file : concern
         {
             context c = () =>
             {
            
             };

             public override Form create_sut()
             {
                 return new DriveBrowser();
             }

             because b = () =>
             {
                sut.ShowDialog(); 
             };

        
             it should_display_the_text_file_in_the_text_box = () =>
             {
            
            
             };
         }
     }
 }
