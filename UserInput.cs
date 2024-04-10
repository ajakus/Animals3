using System;


public class UserInput : UserData, Talkable{
    private string info;

    public UserInput(string info, string name) : base(name) {
        // super(name);
        this.info = info;
    }

    public string GetInfo() {
        return info;
    }

    public void SetInfo(string info) {
        this.info = info;
    }

    // @Override
    //  
    public string Talk() {
        return info;
    }
}