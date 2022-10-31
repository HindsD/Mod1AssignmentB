internal abstract class Pet {
    protected string Name { get; set; }

    public Pet(string name) {
        this.Name = name;
    }

    public string GetName() {
        return Name;
    }
}