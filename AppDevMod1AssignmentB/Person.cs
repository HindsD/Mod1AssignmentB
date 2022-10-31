internal abstract class Person {
    protected string Name { get; set; }

    public Person(string name) {
        this.Name = name;
    }

    public string GetName() {
        return Name;
    }

    public void SetName(string name) {
        this.Name = name;
    }
}