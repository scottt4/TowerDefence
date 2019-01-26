using UnityEngine;

public class DamageEnemies : MonoBehaviour
{
    public static void SetupWeapon(BoardManager board, GameObject weapon)
    {
        GameObject axe = Instantiate(weapon, new Vector3(153 - board.GetOffset(), 267, 0), new Quaternion(0, 0, 0, 0)) as GameObject;

        board.createdWeapons.Add(axe.transform.position);
    }
}
