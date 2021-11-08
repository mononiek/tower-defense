using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public TurretBlueprint PawnTurret;
    public TurretBlueprint KnightTurret;
    
    BuildManager buildManager;

    void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void SelectPawnTurret ()
    {
        Debug.Log("Pawn Turret Selected");
        buildManager.SelectTurretToBuild(PawnTurret);
    }

    public void SelectKnightTurret ()
    {
        Debug.Log("Knight Turret Selected");
        buildManager.SelectTurretToBuild(KnightTurret);
    }
}
