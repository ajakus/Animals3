using System;

public abstract class UserData {
    protected string name;

    public UserData(string name) {
        this.name = name;
    }

    public string GetName() {
        return name;
    }
}