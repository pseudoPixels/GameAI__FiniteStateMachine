using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class State_GoHomeAndSleepTilRested : State {

    //states are made singleton
    private static State_GoHomeAndSleepTilRested instance = null;

    //for thread safety creation of the singleton
    private static readonly object padlock = new object();


    EntityNames entityNames = new EntityNames();


    private State_GoHomeAndSleepTilRested()
    {

    }

    public static State_GoHomeAndSleepTilRested Instance
    {
        get
        {
            lock (padlock)
            {
                if (instance == null)
                {
                    instance = new State_GoHomeAndSleepTilRested();
                }

                return instance;
            }
            
        }
    }

    public override void Enter(Miner miner)
    {
        if(miner.CurrentLocation() != locationType.shack)
        {
            Debug.Log(entityNames.GetEntityName(miner.GetID()) + ": " + "Walking Home...");

            miner.ChangeLocation(locationType.shack);
        }
    }

    public override void Execute(Miner miner)
    {
        //if miner is no more fatigued... lets go for dign' some gold again
        if(miner.IsFatigued() == false)
        {
            Debug.Log(entityNames.GetEntityName(miner.GetID()) + ": " + "Had a Fantastic Nap... Lets go for digging some more nuggets...");

            //change the state for Digging some Nuggets...
            miner.ChangeState(State_EnterMineAndDigForNugget.Instance);

        }
        else
        {
            miner.DecreaseFatigue();
            Debug.Log(entityNames.GetEntityName(miner.GetID()) + ": " + "ZZZ...");
        }
    }

    public override void Exit(Miner miner)
    {
        Debug.Log(entityNames.GetEntityName(miner.GetID()) + ": " + "Leaving House...");
    }

    
}
