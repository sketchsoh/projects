class Player
{
    private string name;
    private string action;

    // Player Initializer
    public Player(string name, string action)
    {
        this.name = name;
        this.action = action;
    }

    public string GetAction()
    {
        return action;
    }

    public string GetName()
    {
        return name;
    }
}
