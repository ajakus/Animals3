using System;

public abstract class Person {
    private string name;

    public Person(string name) {
        this.name = name;
    }

    public string GetName() {
        return name;
    }

    public void SetName(String name) {
        this.name = name;
    }
}