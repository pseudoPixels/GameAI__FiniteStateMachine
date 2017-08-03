using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityNames {

    public enum entityNames {ent_Miner_Bob,ent_Elsa};

    public EntityNames()
    {

    }


    public string GetEntityName(int id)
    {
        if (id == (int)entityNames.ent_Miner_Bob) return "Miner Bob";
        else if (id == (int)entityNames.ent_Miner_Bob) return "Elsa";
        else return "Unknown";
    }

}
