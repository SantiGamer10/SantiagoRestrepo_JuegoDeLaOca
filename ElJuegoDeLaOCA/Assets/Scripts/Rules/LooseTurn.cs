
using System;
using System.Linq;

public class LooseTurn : BoardRule
{
    private int[] rules;

    public LooseTurn(int[] newRules)
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
        return new BoardRuleResult(playerPosition, playerID == 1, playerID == 2, "y pierde un turno");
    }
}
