using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class TaskLoader
{
    public string jsonFile;
    public TaskLoader(string filepath)
    {
        StreamReader reader = new StreamReader(filepath);
        jsonFile = reader.ReadToEnd();
        TaskFile tasks = JsonUtility.FromJson<TaskFile>(jsonFile);
    }
}
[System.Serializable]
public class TaskFile
{
    public Task[] tasks;
}

[System.Serializable]
public class Task 
{
    public int id;
    public string status;
    public string uuid;
    public string entry;
    public string description;
    public string modified;
    public string urgency;
    public string parent = null;
    public string depends = null;
}