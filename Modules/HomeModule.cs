using Nancy;
using FriendLetter.Objects;

namespace FriendLetter
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["form.cshtml"];
      Get["/greeting_card"] = _ =>
      {
        LetterVariables myLetter = new LetterVariables();
        myLetter.SetSender(Request.Query["sender"]);
        myLetter.SetRecipient(Request.Query["recipient"]);
        return View["hello.cshtml", myLetter];
      };
    }
  }
}
