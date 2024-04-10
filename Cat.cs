using System;
using Microsoft.VisualBasic;

public class Cat : Pet, Talkable 
{
    
    private int mousesKilled;

    public Cat(int mousesKilled, string name) : base(name) {
        // base(name);
        this.mousesKilled = mousesKilled;
    }

    public int GetMousesKilled()
    {
        return mousesKilled;
    }

    public void AddMouse() {
        mousesKilled++;
    }
//     @Override
    public string Talk() {
        return "Meow";
    }

//     @Override
    public override string ToString() {
        return "Cat: " + "name=" + name + " mousesKilled=" + mousesKilled;
    }
}
     
