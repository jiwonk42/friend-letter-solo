namespace FriendLetter.Objects
{
  public class LetterVariables
  {
    private string _recipient;
    private string _sender;

    public void SetRecipient(string recipient)
    {
      _recipient = recipient;
    }

    public string GetRecipient()
    {
      return _recipient;
    }

    public void SetSender(string sender)
    {
      _sender = sender;
    }

    public string GetSender()
    {
      return _sender;
    }
  }
}
