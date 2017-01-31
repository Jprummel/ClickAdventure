using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine.SceneManagement;

public class SaveLoadGame : MonoBehaviour {


    public void SaveGame()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/SaveDataSlot.dat");

        SaveData saveData = new SaveData();
        saveData.stage = PlayerInformation.Stage;
        saveData.gold = PlayerInformation.Gold;
        saveData.clickLevel = PlayerInformation.ClickLevel;
        saveData.warriorUnlocked = PlayerInformation.WarriorUnlocked;
        saveData.mageUnlocked = PlayerInformation.MageUnlocked;
        saveData.rangerUnlocked = PlayerInformation.RangerUnlocked;
        saveData.warriorLevel = PlayerInformation.WarriorLevel;
        saveData.mageLevel = PlayerInformation.MageLevel;
        saveData.rangerLevel = PlayerInformation.RangerLevel;
        saveData.currentScene = Application.loadedLevelName;

        bf.Serialize(file, saveData);
        file.Close();
    }

    public void LoadGame()
    {
        if (File.Exists(Application.persistentDataPath + "/SaveDataSlot.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/SaveDataSlot.dat", FileMode.Open);

            SaveData saveData = (SaveData)bf.Deserialize(file);
            PlayerInformation.Stage = saveData.stage;
            PlayerInformation.Gold = saveData.gold;
            PlayerInformation.ClickLevel = saveData.clickLevel;
            PlayerInformation.WarriorUnlocked = saveData.warriorUnlocked;
            PlayerInformation.MageUnlocked = saveData.mageUnlocked;
            PlayerInformation.RangerUnlocked = saveData.rangerUnlocked;
            PlayerInformation.WarriorLevel = saveData.warriorLevel;
            PlayerInformation.MageLevel = saveData.mageLevel;
            PlayerInformation.RangerLevel = saveData.rangerLevel;
            PlayerInformation.CurrentScene = saveData.currentScene;
        }

        SceneManager.LoadScene(PlayerInformation.CurrentScene);
    }

    [System.Serializable]
    public class SaveData
    {
        public int stage;
        public int gold;
        public int clickLevel;

        public bool warriorUnlocked;
        public bool mageUnlocked;
        public bool rangerUnlocked;

        public int warriorLevel;
        public int mageLevel;
        public int rangerLevel;

        public string currentScene;
    }
}
