using System;


public class Teacher : Person, Talkable{
    private int age;

    public Teacher(int age, string name) : base(name) {
        // super(name);
        this.age = age;
    }

    public int GetAge() {
        return age;
    }

    public void SetAge(int age) {
        this.age = age;
    }

    // @Override
    public string Talk() {
        return "Don't forget to do the assigned reading!";
    }
}