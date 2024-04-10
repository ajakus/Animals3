using System;

public class Dog : Pet, Talkable 
{
    private bool friendly;

    public Dog(bool friendly, string name) : base(name) {
        // super(name);
        
        this.friendly = friendly;
    }

    public bool IsFriendly() {
        return friendly;
    }

    // @Override
    public string Talk() {
        return "Bark";
    }

    // @Override
    public override string ToString() {
        return "Dog: " + "name=" + name + " friendly=" + friendly;
    }

}