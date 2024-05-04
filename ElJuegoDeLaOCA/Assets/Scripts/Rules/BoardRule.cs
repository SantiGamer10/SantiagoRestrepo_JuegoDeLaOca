using System;

public class BoardRule
{
    public virtual bool IsCompatible(int playerPosition)
    {
        throw new NotImplementedException();
    }

    public virtual BoardRuleResult Accionar(int playerId, int playerPosition)
    {
        throw new NotImplementedException();
    }
}
