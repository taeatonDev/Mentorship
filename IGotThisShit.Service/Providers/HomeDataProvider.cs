using IGotThisShit.Objects.ViewModels;

namespace IGotThisShit.Service.Providers
{
    public class HomeDataProvider : IDataProvider
    {
        public HomeVModel GetData()
        {
            return new HomeVModel
            {
                ImgPath = "Images/boobs4homepage.jpg",
                Col1Content =
                    @"Short ribs hamburger ex, magna exercitation ribeye voluptate nostrud frankfurter flank ground round salami. Hamburger veniam rump, sint elit tempor proident ut biltong flank aute. Dolore pork flank, rump turducken esse tri-tip ball tip proident jowl ea drumstick sausage. Tri-tip kielbasa jerky, ut occaecat salami bresaola enim proident dolore non. Magna shoulder brisket short loin elit ball tip nisi ea tenderloin. Tri-tip officia nostrud short ribs flank aute pancetta ham hock voluptate cupidatat shoulder fugiat elit rump.
            
                            Beef ribs culpa velit esse, aliquip leberkas dolore elit mollit ullamco adipisicing ribeye strip steak. Beef ribs non enim porchetta elit aute adipisicing. Pig esse venison, enim voluptate turducken culpa landjaeger meatball bacon leberkas shoulder est pastrami. Sausage exercitation landjaeger, ad salami jowl ut voluptate minim shank ham. Dolor hamburger chicken, swine pork chop tongue frankfurter deserunt chuck aliqua incididunt adipisicing quis labore.
            
                            Shankle nulla doner kevin t-bone, bacon pastrami ground round esse ham hock bresaola tri-tip non ut. Nulla veniam sed pork loin ham andouille ut. Spare ribs ham hock tri-tip, laborum esse enim pariatur do ullamco pork loin occaecat ground round. Meatball beef ribs pancetta in magna fugiat tenderloin sunt turkey voluptate dolor mollit bacon jerky. Flank shankle pariatur minim chicken, cow deserunt kielbasa tenderloin aliquip. Dolore labore meatloaf sausage ut, culpa qui.",
                Col2Content =
                    @"Duis ut strip steak, kielbasa cillum capicola meatball nostrud labore shank fugiat. Enim landjaeger dolor short loin dolore. Ullamco beef ribs occaecat, biltong ham hock rump meatball tongue in minim. Cillum turducken tail, proident commodo pork prosciutto non. Enim nulla ut bacon, short ribs proident ad fugiat chuck jerky adipisicing veniam meatloaf pork belly short loin. Venison capicola tail nulla. Tongue salami pork belly, ut filet mignon boudin sunt brisket excepteur leberkas.
            
                            In ground round meatball ut fugiat ham hock cupidatat tenderloin leberkas pork chop nisi. Flank pork jerky ea spare ribs andouille reprehenderit doner corned beef. Deserunt hamburger in boudin andouille pariatur in excepteur officia consequat drumstick flank. Pork loin ut kevin occaecat sausage pastrami hamburger id kielbasa ut capicola pig jowl. Ut ad pig veniam voluptate cow aliqua, adipisicing prosciutto consequat pork belly exercitation do. Meatball in chuck dolore fatback dolor velit minim. Shankle sed swine id beef.
            
                            Does your lorem ipsum text long for something a little meatier? Give our generator a try… it’s tasty!"
            };
        }
    }
}
