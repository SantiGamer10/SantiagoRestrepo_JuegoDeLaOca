
using System.Linq;

public class ThrowAgain : BoardRule
{
    private int[] rules;

    public ThrowAgain(int[] newRules)
    {
        //(DONE) TAREA: RECIBIR EL ARRAY POR PARAMETRO ACA
        rules = newRules;
    }

    public override bool IsCompatible(int playerPosition)
    {
        return rules.ToList().Contains(playerPosition);
    }

    public override BoardRuleResult Accionar(int playerID, int playerPosition)
    {
        return new BoardRuleResult(playerPosition, playerID == 2, playerID == 1, "y tira de nuevo");
    }
}