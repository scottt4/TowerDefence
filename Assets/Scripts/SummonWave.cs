using UnityEngine;

public class SummonWave : MonoBehaviour
{
    #region Level 1
    public static void SummonWaveLevel1(SpawnEnemies s, int wave)
    {
        switch (wave)
        {
            case 1:
                s.EnemiesInWave = 10;
                for (int i = 0; i < s.EnemiesInWave / 2; i++)
                {
                    s.Spawns.Enqueue(s.EnemyDictionary["Rat"]);
                    s.Spawns.Enqueue(s.EnemyDictionary["Bat"]);
                }
                break;
            case 2:
                s.EnemiesInWave = 16;
                for (int i = 0; i < s.EnemiesInWave / 2; i++)
                {
                    s.Spawns.Enqueue(s.EnemyDictionary["Rat"]);
                    s.Spawns.Enqueue(s.EnemyDictionary["Bat"]);
                }
                break;
            case 3:
                s.EnemiesInWave = 10;
                for (int i = 0; i < s.EnemiesInWave; i++)
                {
                    s.Spawns.Enqueue(s.EnemyDictionary["Goblin"]);
                }
                break;
            case 4:
                s.EnemiesInWave = 20;
                for (int i = 0; i < s.EnemiesInWave / 2; i++)
                {
                    s.Spawns.Enqueue(s.EnemyDictionary["Rat"]);
                    s.Spawns.Enqueue(s.EnemyDictionary["Goblin"]);
                }
                break;
            case 5:
                s.EnemiesInWave = 20;
                s.Spawns.Enqueue(s.EnemyDictionary["Skeleton1"]);
                for (int i = 0; i < s.EnemiesInWave / 2; i++)
                {
                    s.Spawns.Enqueue(s.EnemyDictionary["Bat"]);
                    s.Spawns.Enqueue(s.EnemyDictionary["Goblin"]);
                }
                break;
            case 6:
                s.EnemiesInWave = 30;
                for (int i = 0; i < s.EnemiesInWave; i++)
                {
                    s.Spawns.Enqueue(s.EnemyDictionary["Rat"]);
                }
                s.Spawns.Enqueue(s.EnemyDictionary["Skeleton2"]);
                break;
            case 7:
                s.EnemiesInWave = 24;
                for (int i = 0; i < s.EnemiesInWave / 3; i++)
                {
                    s.Spawns.Enqueue(s.EnemyDictionary["Bat"]);
                    s.Spawns.Enqueue(s.EnemyDictionary["Bat"]);
                    s.Spawns.Enqueue(s.EnemyDictionary["Rat"]);
                    s.Spawns.Enqueue(s.EnemyDictionary["Rat"]);
                    s.Spawns.Enqueue(s.EnemyDictionary["Goblin"]);
                    s.Spawns.Enqueue(s.EnemyDictionary["Goblin"]);
                    s.Spawns.Enqueue(s.EnemyDictionary["Skeleton1"]);
                    s.Spawns.Enqueue(s.EnemyDictionary["Skeleton2"]);
                }
                break;
            case 8:
                s.EnemiesInWave = 51;
                for (int i = 0; i < s.EnemiesInWave / 3; i++)
                {
                    s.Spawns.Enqueue(s.EnemyDictionary["Bat"]);
                    s.Spawns.Enqueue(s.EnemyDictionary["Bat"]);
                    s.Spawns.Enqueue(s.EnemyDictionary["Goblin"]);
                }
                break;
            case 9:
                s.EnemiesInWave = 70;
                for (int i = 0; i < s.EnemiesInWave; i++)
                {
                    s.Spawns.Enqueue(s.EnemyDictionary["Bat"]);
                }
                break;
            case 10:
                s.Spawns.Enqueue(s.EnemyDictionary["Ogre"]);
                s.Spawns.Enqueue(s.EnemyDictionary["Ogre"]);
                s.EnemiesInWave = 40;
                for (int i = 0; i < s.EnemiesInWave / 2; i++)
                {
                    s.Spawns.Enqueue(s.EnemyDictionary["Rat"]);
                    s.Spawns.Enqueue(s.EnemyDictionary["Bat"]);
                }
                break;
            case 11:
                s.EnemiesInWave = 100;
                for (int i = 0; i < s.EnemiesInWave / 5; i++)
                {
                    s.Spawns.Enqueue(s.EnemyDictionary["Rat"]);
                    s.Spawns.Enqueue(s.EnemyDictionary["Bat"]);
                    s.Spawns.Enqueue(s.EnemyDictionary["Rat"]);
                    s.Spawns.Enqueue(s.EnemyDictionary["Bat"]);
                    s.Spawns.Enqueue(s.EnemyDictionary["Rat"]);
                }
                break;
            case 12:
                s.EnemiesInWave = 80;
                for (int i = 0; i < s.EnemiesInWave; i++)
                {
                    s.Spawns.Enqueue(s.EnemyDictionary["Goblin"]);
                }
                break;
            case 13:
                s.EnemiesInWave = 80;
                for (int i = 0; i < s.EnemiesInWave / 4; i++)
                {
                    s.Spawns.Enqueue(s.EnemyDictionary["Rat"]);
                    s.Spawns.Enqueue(s.EnemyDictionary["Bat"]);
                    s.Spawns.Enqueue(s.EnemyDictionary["Skeleton1"]);
                    s.Spawns.Enqueue(s.EnemyDictionary["Skeleton2"]);
                }
                break;
            case 14:
                s.EnemiesInWave = 90;
                for (int i = 0; i < s.EnemiesInWave / 3; i++)
                {
                    s.Spawns.Enqueue(s.EnemyDictionary["Bat"]);
                    s.Spawns.Enqueue(s.EnemyDictionary["Snake"]);
                    s.Spawns.Enqueue(s.EnemyDictionary["Skeleton1"]);
                }
                break;
            case 15:
                s.EnemiesInWave = 90;
                s.Spawns.Enqueue(s.EnemyDictionary["Ogre"]);
                s.Spawns.Enqueue(s.EnemyDictionary["Ogre"]);
                for (int i = 0; i < s.EnemiesInWave / 3; i++)
                {
                    s.Spawns.Enqueue(s.EnemyDictionary["Bat"]);
                    s.Spawns.Enqueue(s.EnemyDictionary["Goblin"]);
                    s.Spawns.Enqueue(s.EnemyDictionary["Spectre"]);
                }
                s.Spawns.Enqueue(s.EnemyDictionary["Ogre"]);
                s.Spawns.Enqueue(s.EnemyDictionary["Ogre"]);
                break;
            case 16:
                s.EnemiesInWave = 60;
                for (int i = 0; i < s.EnemiesInWave; i++)
                {
                    s.Spawns.Enqueue(s.EnemyDictionary["Snake"]);
                }
                break;
            case 17:
                s.EnemiesInWave = 120;
                for (int i = 0; i < s.EnemiesInWave / 3; i++)
                {
                    s.Spawns.Enqueue(s.EnemyDictionary["Bat"]);
                    s.Spawns.Enqueue(s.EnemyDictionary["Skeleton2"]);
                    s.Spawns.Enqueue(s.EnemyDictionary["Spectre"]);
                }
                break;
            case 18:
                s.EnemiesInWave = 200;
                for (int i = 0; i < s.EnemiesInWave; i++)
                {
                    s.Spawns.Enqueue(s.EnemyDictionary["Goblin"]);
                }
                break;
            case 19:
                s.EnemiesInWave = 200;
                for (int i = 0; i < s.EnemiesInWave / 2; i++)
                {
                    s.Spawns.Enqueue(s.EnemyDictionary["Bat"]);
                    s.Spawns.Enqueue(s.EnemyDictionary["Snake"]);
                }
                break;
            case 20:
                s.EnemiesInWave = 200;
                for (int i = 0; i < s.EnemiesInWave / 8; i++)
                {
                    s.Spawns.Enqueue(s.EnemyDictionary["Rat"]);
                    s.Spawns.Enqueue(s.EnemyDictionary["Bat"]);
                    s.Spawns.Enqueue(s.EnemyDictionary["Goblin"]);
                    s.Spawns.Enqueue(s.EnemyDictionary["Snake"]);
                    s.Spawns.Enqueue(s.EnemyDictionary["Ogre"]);
                    s.Spawns.Enqueue(s.EnemyDictionary["Spectre"]);
                    s.Spawns.Enqueue(s.EnemyDictionary["Skeleton1"]);
                    s.Spawns.Enqueue(s.EnemyDictionary["Skeleton2"]);
                }
                s.Spawns.Enqueue(s.EnemyDictionary["Boss"]);
                break;
            default:
                break;
        }
    }
    #endregion

    #region Level 2
    public static void SummonWaveLevel2(SpawnEnemies s, int wave)
    {
        switch (wave)
        {
            case 1:
                s.EnemiesInWave = 100;
                for (int i = 0; i < s.EnemiesInWave; i++)
                {
                    s.Spawns.Enqueue(s.EnemyDictionary["Bat"]);
                }
                break;
            case 2:
                s.EnemiesInWave = 150;
                for (int i = 0; i < s.EnemiesInWave / 2; i++)
                {
                    s.Spawns.Enqueue(s.EnemyDictionary["Rat"]);
                    s.Spawns.Enqueue(s.EnemyDictionary["Bat"]);
                }
                break;
            case 3:
                s.EnemiesInWave = 150;
                for (int i = 0; i < s.EnemiesInWave; i++)
                {
                    s.Spawns.Enqueue(s.EnemyDictionary["Goblin"]);
                }
                break;
            case 4:
                s.EnemiesInWave = 200;
                for (int i = 0; i < s.EnemiesInWave / 3; i++)
                {
                    s.Spawns.Enqueue(s.EnemyDictionary["Rat"]);
                    s.Spawns.Enqueue(s.EnemyDictionary["Bat"]);
                    s.Spawns.Enqueue(s.EnemyDictionary["Goblin"]);
                }
                s.Spawns.Enqueue(s.EnemyDictionary["Skeleton1"]);
                s.Spawns.Enqueue(s.EnemyDictionary["Skeleton2"]);

                break;
            case 5:
                s.EnemiesInWave = 200;
                for (int i = 0; i < s.EnemiesInWave / 3; i++)
                {
                    s.Spawns.Enqueue(s.EnemyDictionary["Bat"]);
                    s.Spawns.Enqueue(s.EnemyDictionary["Skeleton1"]);
                    s.Spawns.Enqueue(s.EnemyDictionary["Skeleton2"]);
                }
                s.Spawns.Enqueue(s.EnemyDictionary["Bat"]);
                s.Spawns.Enqueue(s.EnemyDictionary["Bat"]);
                break;
            case 6:
                s.EnemiesInWave = 300;
                for (int i = 0; i < s.EnemiesInWave / 2; i++)
                {
                    s.Spawns.Enqueue(s.EnemyDictionary["Snake"]);
                    s.Spawns.Enqueue(s.EnemyDictionary["Bat"]);
                }
                break;
            case 7:
                s.EnemiesInWave = 300;
                for (int i = 0; i < s.EnemiesInWave / 3; i++)
                {
                    s.Spawns.Enqueue(s.EnemyDictionary["Bat"]);
                    s.Spawns.Enqueue(s.EnemyDictionary["Snake"]);
                    s.Spawns.Enqueue(s.EnemyDictionary["Spectre"]);
                }
                break;
            case 8:
                s.EnemiesInWave = 300;
                for (int i = 0; i < s.EnemiesInWave / 3; i++)
                {
                    s.Spawns.Enqueue(s.EnemyDictionary["Snake"]);
                    s.Spawns.Enqueue(s.EnemyDictionary["Goblin"]);
                    s.Spawns.Enqueue(s.EnemyDictionary["Skeleton1"]);
                }
                break;
            case 9:
                s.EnemiesInWave = 300;
                for (int i = 0; i < s.EnemiesInWave / 2; i++)
                {
                    s.Spawns.Enqueue(s.EnemyDictionary["Skeleton1"]);
                    s.Spawns.Enqueue(s.EnemyDictionary["Skeleton2"]);
                }
                break;
            case 10:
                s.EnemiesInWave = 300;
                for (int i = 0; i < s.EnemiesInWave / 2; i++)
                {
                    s.Spawns.Enqueue(s.EnemyDictionary["Bat"]);
                    s.Spawns.Enqueue(s.EnemyDictionary["Ogre"]);
                }
                break;
            case 11:
                s.EnemiesInWave = 350;
                s.Spawns.Enqueue(s.EnemyDictionary["Bat"]);
                s.Spawns.Enqueue(s.EnemyDictionary["Bat"]);
                for (int i = 0; i < s.EnemiesInWave / 3; i++)
                {
                    s.Spawns.Enqueue(s.EnemyDictionary["Spectre"]);
                    s.Spawns.Enqueue(s.EnemyDictionary["Skeleton1"]);
                    s.Spawns.Enqueue(s.EnemyDictionary["Skeleton2"]);
                }
                break;
            case 12:
                s.EnemiesInWave = 350;
                for (int i = 0; i < s.EnemiesInWave; i++)
                {
                    s.Spawns.Enqueue(s.EnemyDictionary["Ogre"]);
                }
                break;
            case 13:
                s.EnemiesInWave = 400;
                for (int i = 0; i < s.EnemiesInWave; i++)
                {
                    s.Spawns.Enqueue(s.EnemyDictionary["Spectre"]);
                }
                break;
            case 14:
                s.EnemiesInWave = 500;
                for (int i = 0; i < s.EnemiesInWave; i++)
                {
                    s.Spawns.Enqueue(s.EnemyDictionary["Snake"]);
                }
                break;
            case 15:
                s.EnemiesInWave = 600;

                for (int i = 0; i < s.EnemiesInWave; i++)
                {
                    s.Spawns.Enqueue(s.EnemyDictionary["Bat"]);
                }
                break;
            case 16:
                s.EnemiesInWave = 10;
                for (int i = 0; i < s.EnemiesInWave; i++)
                {
                    s.Spawns.Enqueue(s.EnemyDictionary["Boss"]);
                }
                break;
            case 17:
                s.EnemiesInWave = 500;
                s.Spawns.Enqueue(s.EnemyDictionary["Boss"]);
                s.Spawns.Enqueue(s.EnemyDictionary["Boss"]);
                for (int i = 0; i < s.EnemiesInWave - 4; i++)
                {
                    s.Spawns.Enqueue(s.EnemyDictionary["Bat"]);
                }
                s.Spawns.Enqueue(s.EnemyDictionary["Boss"]);
                s.Spawns.Enqueue(s.EnemyDictionary["Boss"]);
                break;
            case 18:
                s.EnemiesInWave = 700;
                for (int i = 0; i < s.EnemiesInWave; i++)
                {
                    s.Spawns.Enqueue(s.EnemyDictionary["Goblin"]);
                }
                break;
            case 19:
                s.EnemiesInWave = 800;
                for (int i = 0; i < s.EnemiesInWave / 2; i++)
                {
                    s.Spawns.Enqueue(s.EnemyDictionary["Snake"]);
                }
                break;
            case 20:
                s.EnemiesInWave = 805;
                for (int i = 0; i < s.EnemiesInWave / 8; i++)
                {
                    s.Spawns.Enqueue(s.EnemyDictionary["Rat"]);
                    s.Spawns.Enqueue(s.EnemyDictionary["Bat"]);
                    s.Spawns.Enqueue(s.EnemyDictionary["Goblin"]);
                    s.Spawns.Enqueue(s.EnemyDictionary["Snake"]);
                    s.Spawns.Enqueue(s.EnemyDictionary["Ogre"]);
                    s.Spawns.Enqueue(s.EnemyDictionary["Spectre"]);
                    s.Spawns.Enqueue(s.EnemyDictionary["Skeleton1"]);
                    s.Spawns.Enqueue(s.EnemyDictionary["Skeleton2"]);
                }
                s.Spawns.Enqueue(s.EnemyDictionary["Boss"]);
                s.Spawns.Enqueue(s.EnemyDictionary["Boss"]);
                s.Spawns.Enqueue(s.EnemyDictionary["Boss"]);
                s.Spawns.Enqueue(s.EnemyDictionary["Boss"]);
                s.Spawns.Enqueue(s.EnemyDictionary["Boss"]);
                break;
            default:
                break;
        }
    }
    #endregion
}
