using Nancy;
using FriendLetter.Objects;

namespace FriendLetter
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>
      {
        LetterVariables myLetter = new LetterVariables();
        myLetter.SetRecipient("Jiwon");
        myLetter.SetSender("V");
        return View["hello.cshtml", myLetter];
      };
    }
  }
}
