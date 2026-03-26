namespace Inheritance.Models;
internal class Team : Sponsor
{
    private string _teamName;
    public Team(string owner, string team) : base(owner)
    {
        _teamName = team;
    }

    /// <summary>
    /// This method will print Information of team and owner
    /// </summary>
    /// <returns></returns>
    public string PrintInfo()
    {
        return $"The owner of {_teamName} is {owner}";
    }
}
