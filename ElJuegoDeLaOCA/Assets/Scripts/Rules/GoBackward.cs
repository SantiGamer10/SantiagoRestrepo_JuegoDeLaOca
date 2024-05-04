
using System.Collections.Generic;

public class GoBackward : BoardRule
{
    private Dictionary<int, int> rules;

    public GoBackward(Dictionary<int, int> newRules)
    {
        //(DONE) TAREA: RECIBIR EL DICCIONARO POR PARAMETRO ACA
        rules = newRules;
    }

    public override bool IsCompatible(int playerPosition)
    {
        return rules.ContainsKey(playerPosition);
    }

    public override BoardRuleResult Accionar(int playerID, int playerPosition)
    {
        int newPos = rules[playerPosition];
        return new BoardRuleResult(newPos, false, false, "y retrocede al casillero " + newPos);
    }
}