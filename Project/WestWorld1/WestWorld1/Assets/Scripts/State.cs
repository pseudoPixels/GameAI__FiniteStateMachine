using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State  {

    public abstract void Enter(Miner miner);

    public abstract void Execute(Miner miner);

    public abstract void Exit(Miner miner);

}
