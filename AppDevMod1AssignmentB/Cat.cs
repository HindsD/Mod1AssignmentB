using System;
internal class Cat : Pet, Talkable {
    public int MousesKilled { get; set; }

    public Cat(int mousesKilled, string name) : base(name){
        this.Name = name;
        this.MousesKilled = mousesKilled;
    }

    public int GetMousesKilled() {
        return MousesKilled;
    }

    public void AddMouse() {
        MousesKilled++;
    }

    public string GetName()
    {
        return Name;
    }

    public string Talk() {
        return "Meow";
    }

    public override string ToString() {
        return "Cat: " + "name=" + Name + " mousesKilled=" + MousesKilled;
    }
}